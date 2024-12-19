using kütüphane_otomasyonu.kütüphaneOtomasyonuDataSet3TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphane_otomasyonu
{

  

    public partial class kitapal : Form
    {
        private string connectionString = @"Data Source=DESKTOP-AQ2MBA7\SQLEXPRESS;Initial Catalog=kütüphaneOtomasyonu;Integrated Security=True;";
        

        public kitapal()
        {
            InitializeComponent();
        }


        private void KitapAlma(SqlConnection connection, string kullaniciId, int kitap_id)
        {
            // Transaction başlat
            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    // Kitap alma işlemini BookLoans tablosuna ekle
                    string insertQuery = "INSERT INTO BookLoans (KullaniciId, kitapId, AlisTarihi, TeslimTarihi, GeriVerildi) " +
                                         "VALUES (@KullaniciId, @KitapId, @AlisTarihi, @TeslimTarihi, @GeriVerildi)";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection, transaction))
                    {
                        insertCmd.Parameters.Add("@KullaniciId", SqlDbType.VarChar).Value = kullaniciId;
                        insertCmd.Parameters.Add("@KitapId", SqlDbType.Int).Value = kitap_id;
                        insertCmd.Parameters.Add("@AlisTarihi", SqlDbType.DateTime).Value = DateTime.Now;
                        insertCmd.Parameters.Add("@TeslimTarihi", SqlDbType.DateTime).Value = DBNull.Value; // Teslim tarihi henüz belirlenmedi
                        insertCmd.Parameters.Add("@GeriVerildi", SqlDbType.Bit).Value = 0; // Kitap alınmış, henüz geri verilmemiş

                        insertCmd.ExecuteNonQuery();
                    }

                    // Stok miktarını azalt (kitap alınmış)
                    string updateQuery = "UPDATE Books SET StokMiktari = StokMiktari - 1 WHERE kitap_id = @KitapId AND StokMiktari > 0";

                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection, transaction))
                    {
                        updateCmd.Parameters.Add("@KitapId", SqlDbType.Int).Value = kitap_id;

                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            // Eğer kitap stoğu sıfır ise, stok güncellemesi yapılmaz
                            MessageBox.Show("Bu kitap şu an mevcut değil.");
                            return;
                        }
                    }

                    // İşlemler başarılı ise commit işlemi
                    transaction.Commit();
                    MessageBox.Show("Kitap başarıyla alındı!");
                }
                catch (Exception ex)
                {
                    // Hata durumunda rollback işlemi
                    transaction.Rollback();
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void kitapal_Load(object sender, EventArgs e)
        {
            // TODO: Veri yükleme işlemleri burada yapılabilir.
            this.bookLoansTableAdapter2.Fill(this.kütüphaneOtomasyonuDataSet19.BookLoans);
            this.booksTableAdapter2.Fill(this.kütüphaneOtomasyonuDataSet18.Books);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Optional: Girişte yapılan değişiklikleri takip et
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Kitap id'sini almak
                int kitapId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["kitap_id"].Value);

                // Kullanıcı seçimi kontrolü
                if (comboBox1.SelectedItem != null)
                {
                    string kullaniciId = comboBox1.SelectedItem.ToString();
                    KitapAl(kullaniciId, kitapId);  // Kitap alma işlemi
                }
                else
                {
                    MessageBox.Show("Lütfen bir kullanıcı seçin.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kitap seçin.");
            }
        }

        // Kitap alma işlemi
        private void KitapAl(string kullaniciId, int kitapId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Kitap alma işlemi
                    string insertQuery = "INSERT INTO BookLoans (KullaniciId, KitapId, AlisTarihi, TeslimTarihi, GeriVerildi) VALUES (@KullaniciId, @KitapId, @AlisTarihi, NULL, 0)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@KullaniciId", kullaniciId);
                        insertCmd.Parameters.AddWithValue("@KitapId", kitapId);
                        insertCmd.Parameters.AddWithValue("@AlisTarihi", DateTime.Now);
                        insertCmd.ExecuteNonQuery();
                    }

                    // Stok güncelleme
                    string updateQuery = "UPDATE Books SET StokMiktari = StokMiktari - 1 WHERE kitap_id = @KitapId";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection))
                    {
                        updateCmd.Parameters.AddWithValue("@KitapId", kitapId);
                        updateCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Kitap başarıyla alındı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
