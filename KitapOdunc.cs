using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphane_otomasyonu
{
    public partial class KitapOdunc : Form
    {
        public KitapOdunc()
        {
            InitializeComponent();
        }

        private void KitapOdunc_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kütüphaneOtomasyonuDataSet16.Bookss' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            

            this.bookLoansTableAdapter.Fill(this.kütüphaneOtomasyonuDataSet3.BookLoans);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kütüphane kütüphaneform = new kütüphane();
            kütüphaneform.Show();
            this.Hide(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kitapAdi = textBox7.Text;
            string yazarAdi = textBox7.Text;
            DateTime oduncTarihi = dtpOduncTarihi.Value;
            DateTime iadeTarihi = dtpIadeTarihi.Value;

            // Kitap bilgileri doğrulama
            if (string.IsNullOrEmpty(kitapAdi) || string.IsNullOrEmpty(yazarAdi))
            {
                MessageBox.Show("Kitap adı ve yazar adı boş olamaz!");
                return;
            }

            // Yeni kitap objesi oluştur
            Book yeniKitap = new Book(kitapAdi, yazarAdi, oduncTarihi, iadeTarihi);

            // Kitapları listeye ekle
            kitaplar.Add(yeniKitap);

            // Listeyi DataGridView'e güncelle
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = kitaplar;

            // Metin kutularını temizle
            textBox7.Clear();
            textBox7.Clear();
        }
        private void btnIadeEt_Click(object sender, EventArgs e)
        {
            if (dgvKitaplar.SelectedRows.Count > 0)
            {
                int seciliKitapIndex = dgvKitaplar.SelectedRows[0].Index;

                // Seçilen kitabı listeden çıkar
                kitaplar.RemoveAt(seciliKitapIndex);

                // Listeyi tekrar DataGridView'e güncelle
                dgvKitaplar.DataSource = null;
                dgvKitaplar.DataSource = kitaplar;
            }
            else
            {
                MessageBox.Show("Lütfen iade edilecek bir kitap seçin.");
            }
        }
    }

    // Kitap sınıfı
    public class Book
    {
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public DateTime OduncTarihi { get; set; }
        public DateTime IadeTarihi { get; set; }

        public Book(string kitapAdi, string yazarAdi, DateTime oduncTarihi, DateTime iadeTarihi)
        {
            KitapAdi = kitapAdi;
            YazarAdi = yazarAdi;
            OduncTarihi = oduncTarihi;
            IadeTarihi = iadeTarihi;
        }
    }
}
        // Kitap iade etmek için butona tıklandığında çalışacak metod
    }
}

