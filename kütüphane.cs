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
    public partial class kütüphane : Form
    {
        public static string genel_bilgi = "";
        SqlConnection bağlantı = new SqlConnection(@"Data Source=DESKTOP-AQ2MBA7\SQLEXPRESS;Initial Catalog=kütüphaneOtomasyonu;Integrated Security=True;");
        public kütüphane()
        {
            InitializeComponent();
        }

        private void kİTAPEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string KullaniciAdi = "Aykutz";
            string Sifre = "Aykut";
            try
            {
                bağlantı.Open();
                string sorgu = "SELECT * FROM Users WHERE KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre";
                SqlCommand command = new SqlCommand(sorgu, bağlantı);
                command.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
                command.Parameters.AddWithValue("@Sifre", Sifre);
                SqlDataReader oku = command.ExecuteReader();



                if (oku.Read())
                {
                    genel_bilgi = "Hoşgeldin" + oku["KullaniciAdi"].ToString();
                    
                    Ana Anaform = new Ana();
                    Anaform.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("hata");
            }
            finally
            {
                if (bağlantı.State == System.Data.ConnectionState.Open)
                {
                    bağlantı.Close();


                }
            }
        }

        private void kİTAPALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string KullaniciAdi = "Aykutz";
            string Sifre = "Aykut";
            try
            {
                bağlantı.Open();
                string sorgu = "SELECT * FROM Users WHERE KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre";
                SqlCommand command = new SqlCommand(sorgu, bağlantı);
                command.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
                command.Parameters.AddWithValue("@Sifre", Sifre);
                SqlDataReader oku = command.ExecuteReader();



                if (oku.Read())
                {
                    genel_bilgi = "Hoşgeldin" + oku["KullaniciAdi"].ToString();
                    
                    kitapal kitapalform = new kitapal();
                    kitapalform.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("hata");
            }
            finally
            {
                if (bağlantı.State == System.Data.ConnectionState.Open)
                {
                    bağlantı.Close();


                }
            }
        }

        private void kİTAPLIKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string KullaniciAdi = "Aykutz";
            string Sifre = "Aykut";
            try
            {
                bağlantı.Open();
                string sorgu = "SELECT * FROM Users WHERE KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre";
                SqlCommand command = new SqlCommand(sorgu, bağlantı);
                command.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
                command.Parameters.AddWithValue("@Sifre", Sifre);
                SqlDataReader oku = command.ExecuteReader();



                if (oku.Read())
                {
                    genel_bilgi = "Hoşgeldin" + oku["KullaniciAdi"].ToString();
                    
                    kitaplık kitaplıkform = new kitaplık();
                    kitaplıkform.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("hata");
            }
            finally
            {
                if (bağlantı.State == System.Data.ConnectionState.Open)
                {
                    bağlantı.Close();


                }
            }
        }

        private void kİTAPTESLİMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string KullaniciAdi = "Aykutz";
            string Sifre = "Aykut";
            try
            {
                bağlantı.Open();
                string sorgu = "SELECT * FROM Users WHERE KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre";
                SqlCommand command = new SqlCommand(sorgu, bağlantı);
                command.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
                command.Parameters.AddWithValue("@Sifre", Sifre);
                SqlDataReader oku = command.ExecuteReader();



                if (oku.Read())
                {
                    genel_bilgi = "Hoşgeldin" + oku["KullaniciAdi"].ToString();
                    
                    KitapOdunc kitapOduncform = new KitapOdunc();
                    kitapOduncform.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("hata");
            }
            finally
            {
                if (bağlantı.State == System.Data.ConnectionState.Open)
                {
                    bağlantı.Close();


                }
            }
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}




