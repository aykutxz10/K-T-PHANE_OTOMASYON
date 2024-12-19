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
    public partial class kitaplık : Form
    {
        public kitaplık()
        {
            InitializeComponent();
        }

        private void kitaplık_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kütüphaneOtomasyonuDataSet15.Bookss' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            
            // TODO: Bu kod satırı 'kütüphaneOtomasyonuDataSet13.Books' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.booksTableAdapter.Fill(this.kütüphaneOtomasyonuDataSet13.Books);
            // TODO: Bu kod satırı 'kütüphaneOtomasyonuDataSet8.BookLoans' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bookLoansTableAdapter.Fill(this.kütüphaneOtomasyonuDataSet8.BookLoans);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kütüphane kütüphaneform = new kütüphane();
            kütüphaneform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
