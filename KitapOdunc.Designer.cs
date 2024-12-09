namespace kütüphane_otomasyonu
{
    partial class KitapOdunc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kütüphaneOtomasyonuDataSet3 = new kütüphane_otomasyonu.kütüphaneOtomasyonuDataSet3();
            this.bookLoansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookLoansTableAdapter = new kütüphane_otomasyonu.kütüphaneOtomasyonuDataSet3TableAdapters.BookLoansTableAdapter();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teslimTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geriVerildiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kütüphaneOtomasyonuDataSet4 = new kütüphane_otomasyonu.kütüphaneOtomasyonuDataSet4();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new kütüphane_otomasyonu.kütüphaneOtomasyonuDataSet4TableAdapters.BooksTableAdapter();
            this.ıdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayineviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayimTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfaSayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokMiktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonuDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookLoansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonuDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.kullaniciIdDataGridViewTextBoxColumn,
            this.kitapIdDataGridViewTextBoxColumn,
            this.alisTarihiDataGridViewTextBoxColumn,
            this.teslimTarihiDataGridViewTextBoxColumn,
            this.geriVerildiDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.bookLoansBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(264, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(524, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn1,
            this.kitapAdiDataGridViewTextBoxColumn,
            this.yazarDataGridViewTextBoxColumn,
            this.yayineviDataGridViewTextBoxColumn,
            this.yayimTarihiDataGridViewTextBoxColumn,
            this.sayfaSayisiDataGridViewTextBoxColumn,
            this.stokMiktariDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.booksBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(776, 167);
            this.dataGridView2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(50, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "GERİ VER";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "KİTABI GERİ VER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::kütüphane_otomasyonu.Properties.Resources.kkkk;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // kütüphaneOtomasyonuDataSet3
            // 
            this.kütüphaneOtomasyonuDataSet3.DataSetName = "kütüphaneOtomasyonuDataSet3";
            this.kütüphaneOtomasyonuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookLoansBindingSource
            // 
            this.bookLoansBindingSource.DataMember = "BookLoans";
            this.bookLoansBindingSource.DataSource = this.kütüphaneOtomasyonuDataSet3;
            // 
            // bookLoansTableAdapter
            // 
            this.bookLoansTableAdapter.ClearBeforeFill = true;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Width = 125;
            // 
            // kullaniciIdDataGridViewTextBoxColumn
            // 
            this.kullaniciIdDataGridViewTextBoxColumn.DataPropertyName = "KullaniciId";
            this.kullaniciIdDataGridViewTextBoxColumn.HeaderText = "KullaniciId";
            this.kullaniciIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullaniciIdDataGridViewTextBoxColumn.Name = "kullaniciIdDataGridViewTextBoxColumn";
            this.kullaniciIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapIdDataGridViewTextBoxColumn
            // 
            this.kitapIdDataGridViewTextBoxColumn.DataPropertyName = "KitapId";
            this.kitapIdDataGridViewTextBoxColumn.HeaderText = "KitapId";
            this.kitapIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapIdDataGridViewTextBoxColumn.Name = "kitapIdDataGridViewTextBoxColumn";
            this.kitapIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // alisTarihiDataGridViewTextBoxColumn
            // 
            this.alisTarihiDataGridViewTextBoxColumn.DataPropertyName = "AlisTarihi";
            this.alisTarihiDataGridViewTextBoxColumn.HeaderText = "AlisTarihi";
            this.alisTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alisTarihiDataGridViewTextBoxColumn.Name = "alisTarihiDataGridViewTextBoxColumn";
            this.alisTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // teslimTarihiDataGridViewTextBoxColumn
            // 
            this.teslimTarihiDataGridViewTextBoxColumn.DataPropertyName = "TeslimTarihi";
            this.teslimTarihiDataGridViewTextBoxColumn.HeaderText = "TeslimTarihi";
            this.teslimTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teslimTarihiDataGridViewTextBoxColumn.Name = "teslimTarihiDataGridViewTextBoxColumn";
            this.teslimTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // geriVerildiDataGridViewCheckBoxColumn
            // 
            this.geriVerildiDataGridViewCheckBoxColumn.DataPropertyName = "GeriVerildi";
            this.geriVerildiDataGridViewCheckBoxColumn.HeaderText = "GeriVerildi";
            this.geriVerildiDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.geriVerildiDataGridViewCheckBoxColumn.Name = "geriVerildiDataGridViewCheckBoxColumn";
            this.geriVerildiDataGridViewCheckBoxColumn.Width = 125;
            // 
            // kütüphaneOtomasyonuDataSet4
            // 
            this.kütüphaneOtomasyonuDataSet4.DataSetName = "kütüphaneOtomasyonuDataSet4";
            this.kütüphaneOtomasyonuDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.kütüphaneOtomasyonuDataSet4;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // ıdDataGridViewTextBoxColumn1
            // 
            this.ıdDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn1.Name = "ıdDataGridViewTextBoxColumn1";
            this.ıdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // kitapAdiDataGridViewTextBoxColumn
            // 
            this.kitapAdiDataGridViewTextBoxColumn.DataPropertyName = "KitapAdi";
            this.kitapAdiDataGridViewTextBoxColumn.HeaderText = "KitapAdi";
            this.kitapAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapAdiDataGridViewTextBoxColumn.Name = "kitapAdiDataGridViewTextBoxColumn";
            this.kitapAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // yazarDataGridViewTextBoxColumn
            // 
            this.yazarDataGridViewTextBoxColumn.DataPropertyName = "Yazar";
            this.yazarDataGridViewTextBoxColumn.HeaderText = "Yazar";
            this.yazarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yazarDataGridViewTextBoxColumn.Name = "yazarDataGridViewTextBoxColumn";
            this.yazarDataGridViewTextBoxColumn.Width = 125;
            // 
            // yayineviDataGridViewTextBoxColumn
            // 
            this.yayineviDataGridViewTextBoxColumn.DataPropertyName = "Yayinevi";
            this.yayineviDataGridViewTextBoxColumn.HeaderText = "Yayinevi";
            this.yayineviDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yayineviDataGridViewTextBoxColumn.Name = "yayineviDataGridViewTextBoxColumn";
            this.yayineviDataGridViewTextBoxColumn.Width = 125;
            // 
            // yayimTarihiDataGridViewTextBoxColumn
            // 
            this.yayimTarihiDataGridViewTextBoxColumn.DataPropertyName = "YayimTarihi";
            this.yayimTarihiDataGridViewTextBoxColumn.HeaderText = "YayimTarihi";
            this.yayimTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yayimTarihiDataGridViewTextBoxColumn.Name = "yayimTarihiDataGridViewTextBoxColumn";
            this.yayimTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // sayfaSayisiDataGridViewTextBoxColumn
            // 
            this.sayfaSayisiDataGridViewTextBoxColumn.DataPropertyName = "SayfaSayisi";
            this.sayfaSayisiDataGridViewTextBoxColumn.HeaderText = "SayfaSayisi";
            this.sayfaSayisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sayfaSayisiDataGridViewTextBoxColumn.Name = "sayfaSayisiDataGridViewTextBoxColumn";
            this.sayfaSayisiDataGridViewTextBoxColumn.Width = 125;
            // 
            // stokMiktariDataGridViewTextBoxColumn
            // 
            this.stokMiktariDataGridViewTextBoxColumn.DataPropertyName = "StokMiktari";
            this.stokMiktariDataGridViewTextBoxColumn.HeaderText = "StokMiktari";
            this.stokMiktariDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokMiktariDataGridViewTextBoxColumn.Name = "stokMiktariDataGridViewTextBoxColumn";
            this.stokMiktariDataGridViewTextBoxColumn.Width = 125;
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "Aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "Aciklama";
            this.aciklamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            this.aciklamaDataGridViewTextBoxColumn.Width = 125;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox7.Location = new System.Drawing.Point(12, 267);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(246, 38);
            this.textBox7.TabIndex = 23;
            // 
            // KitapOdunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "KitapOdunc";
            this.Text = "KitapOdunc";
            this.Load += new System.EventHandler(this.KitapOdunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonuDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookLoansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonuDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private kütüphaneOtomasyonuDataSet3 kütüphaneOtomasyonuDataSet3;
        private System.Windows.Forms.BindingSource bookLoansBindingSource;
        private kütüphaneOtomasyonuDataSet3TableAdapters.BookLoansTableAdapter bookLoansTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teslimTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn geriVerildiDataGridViewCheckBoxColumn;
        private kütüphaneOtomasyonuDataSet4 kütüphaneOtomasyonuDataSet4;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private kütüphaneOtomasyonuDataSet4TableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayineviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayimTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfaSayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokMiktariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox7;
    }
}