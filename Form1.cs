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
    public partial class Form1 : Form
    {
        public static string genel_bilgi = "";
        SqlConnection bağlantı = new SqlConnection(@"Data Source=DESKTOP-AQ2MBA7\SQLEXPRESS;Initial Catalog=kütüphaneOtomasyonu;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("kullanıcı Adınızı Gİrin");
                return;


            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("şifre gir");
                return;
            }
            string KullaniciAdi = textBox1.Text;
            string Sifre = textBox2.Text;
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
                    MessageBox.Show(genel_bilgi);
                    kütüphane kütüphaneform = new kütüphane();
                    kütüphaneform.Show();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


