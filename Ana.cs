﻿using kütüphane_otomasyonu.kütüphaneOtomasyonuDataSet1TableAdapters;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace kütüphane_otomasyonu
{
    public partial class Ana : Form
    {
        SqlConnection bağlantı = new SqlConnection(@"Data Source=DESKTOP-AQ2MBA7\SQLEXPRESS;Initial Catalog=kütüphaneOtomasyonu;Integrated Security=True;");

        public Ana()
        {
            InitializeComponent();

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            // TextBox değerlerini al
            string KitapAdi = textBox1.Text;
            string Yazar = textBox2.Text;
            string Yayinevi = textBox3.Text;
            string YayimTarihi = textBox6.Text;

            // Sayfa Sayısı integer ve hatalı girişe karşı try-catch kullanımı
            int SayfaSayisi;
            if (!int.TryParse(textBox4.Text, out SayfaSayisi))
            {
                MessageBox.Show("Sayfa Sayısı geçerli bir sayı olmalıdır.");
                return;
            }

            string StokMiktari = textBox5.Text;

            // SQL bağlantısı ve komut kullanımı
            string connectionString = @"Data Source=DESKTOP-AQ2MBA7\SQLEXPRESS;Initial Catalog=kütüphaneOtomasyonu;Integrated Security=True;";
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "INSERT INTO Books (KitapAdi, Yazar, Yayinevi, YayimTarihi, SayfaSayisi, StokMiktari) " +
                                   "VALUES (@KitapAdi, @Yazar, @Yayinevi, @YayimTarihi, @SayfaSayisi, @StokMiktari)";

                    using (SqlCommand cmd = new SqlCommand(sorgu, baglanti))
                    {
                        cmd.Parameters.AddWithValue("@KitapAdi", KitapAdi);
                        cmd.Parameters.AddWithValue("@Yazar", Yazar);
                        cmd.Parameters.AddWithValue("@Yayinevi", Yayinevi);
                        cmd.Parameters.AddWithValue("@YayimTarihi", YayimTarihi);
                        cmd.Parameters.AddWithValue("@SayfaSayisi", SayfaSayisi);
                        cmd.Parameters.AddWithValue("@StokMiktari", StokMiktari);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Kitap başarıyla eklendi!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string kitapAdi = textBox1.Text;  // Kullanıcının alacağı kitabın adı
                string kullaniciAdi = "KullaniciAdi"; // Örnek kullanıcı adı (bu, kullanıcı girişi ile alınabilir)

                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-AQ2MBA7\SQLEXPRESS;Initial Catalog=kütüphaneOtomasyonu;Integrated Security=True;"))
                {
                    connection.Open();

                    // Kitap adını sorgula ve stok miktarını kontrol et
                    string query = "SELECT StokMiktari FROM Books WHERE KitapAdi = @KitapAdi";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@KitapAdi", kitapAdi);
                    int stokMiktari = (int)cmd.ExecuteScalar();

                    if (stokMiktari > 0)
                    {
                        // Kitap alma işlemini Transactions tablosuna ekle
                        string insertQuery = "INSERT INTO BookLoans (KullaniciAdi, KitapAdi, AlisTarihi, GeriVerildi) VALUES (@KullaniciAdi, @KitapAdi, @AlisTarihi, @GeriVerildi)";
                        SqlCommand insertCmd = new SqlCommand(insertQuery, connection);
                        insertCmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                        insertCmd.Parameters.AddWithValue("@KitapAdi", kitapAdi);
                        insertCmd.Parameters.AddWithValue("@AlisTarihi", DateTime.Now);
                        insertCmd.Parameters.AddWithValue("@GeriVerildi", 0); // Kitap alınmış, henüz geri verilmemiş (0)
                        insertCmd.ExecuteNonQuery();

                        // Stok miktarını azalt
                        string updateQuery = "UPDATE Books SET StokMiktari = StokMiktari - 1 WHERE KitapAdi = @KitapAdi";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, connection);
                        updateCmd.Parameters.AddWithValue("@KitapAdi", kitapAdi);
                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("Kitap başarıyla alındı!");
                    }
                    else
                    {
                        MessageBox.Show("Bu kitapta stok bulunmamaktadır!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
        private void Ana_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kütüphaneOtomasyonuDataSet17.Bookss' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            
            // TODO: Bu kod satırı 'kütüphaneOtomasyonuDataSet2.BookLoans' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bookLoansTableAdapter.Fill(this.kütüphaneOtomasyonuDataSet2.BookLoans);
            // TODO: Bu kod satırı 'kütüphaneOtomasyonuDataSet1.Books' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           

        }



        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            try
            {
                // DataGridView'i temizle
                dataGridView1.Rows.Clear();

                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-AQ2MBA7\SQLEXPRESS;Initial Catalog=kütüphaneOtomasyonu;Integrated Security=True;"))
                {
                    connection.Open();
                    string query = "SELECT t.TransactionId, b.KitapAdi, t.AlisTarihi, t.TeslimTarihi, t.GeriVerildi " +
                                   "FROM Transactions t " +
                                   "INNER JOIN Books b ON t.KitapId = b.Id " +
                                   "WHERE t.KullaniciId = @KullaniciId"; // Kullanıcı ID'si sorgusu
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@KullaniciId", 1); // Kullanıcı ID'si (örnek olarak 1)
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int transactionId = reader.GetInt32(0); // TransactionId
                        string kitapAdi = reader.GetString(1);  // Kitap Adı
                        DateTime almaTarihi = reader.GetDateTime(2); // Alma Tarihi
                        DateTime? iadeTarihi = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3); // İade Tarihi
                        int durum = reader.GetInt32(4); // Geri Verildi (1 veya 0)

                        dataGridView1.Rows.Add(transactionId, kitapAdi, almaTarihi, iadeTarihi, durum);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            kütüphane kütüphaneform = new kütüphane();
            kütüphaneform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Arama metni değiştikçe veritabanından veri çekiyoruz
            string searchText = textBox1.Text; // TextBox9'dan alınan arama metni
            AramaYap(searchText);
        }
        private void AramaYap(string searchText)
        {
            string isim = textBox1.Text;

            try
            {
                // SQL sorgusunu oluşturuyoruz
                string sorgu = "SELECT * FROM Books WHERE KitapAdi LIKE @KitapAdi";
                SqlCommand command = new SqlCommand(sorgu, bağlantı);
                command.Parameters.AddWithValue("@KitapAdi", "%" + searchText + "%"); // LIKE operatörü ile esnek arama

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable(); // Veritabanından alınan veriyi tutacak DataTable
                dataAdapter.Fill(dt); // DataTable'a veriyi yüklüyoruz

                // DataGridView'e sonuçları bağlıyoruz
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message); // Hata mesajı gösteriyoruz
            }
        }
    }
}




