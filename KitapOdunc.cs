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
            // TODO: Bu kod satırı 'kütüphaneOtomasyonuDataSet4.Books' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.booksTableAdapter.Fill(this.kütüphaneOtomasyonuDataSet4.Books);
            // TODO: Bu kod satırı 'kütüphaneOtomasyonuDataSet3.BookLoans' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bookLoansTableAdapter.Fill(this.kütüphaneOtomasyonuDataSet3.BookLoans);

        }
    }
}
