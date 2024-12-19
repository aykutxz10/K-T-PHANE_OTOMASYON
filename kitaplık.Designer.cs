namespace kütüphane_otomasyonu
{
    partial class kitaplık
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.kütüphaneOtomasyonuDataSet8 = new kütüphane_otomasyonu.kütüphaneOtomasyonuDataSet8();
            this.bookLoansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookLoansTableAdapter = new kütüphane_otomasyonu.kütüphaneOtomasyonuDataSet8TableAdapters.BookLoansTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.kütüphaneOtomasyonuDataSet13 = new kütüphane_otomasyonu.kütüphaneOtomasyonuDataSet13();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new kütüphane_otomasyonu.kütüphaneOtomasyonuDataSet13TableAdapters.BooksTableAdapter();
            this.kütüphaneOtomasyonuDataSet15 = new kütüphane_otomasyonu.kütüphaneOtomasyonuDataSet15();
            this.bookssBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookssTableAdapter = new kütüphane_otomasyonu.kütüphaneOtomasyonuDataSet15TableAdapters.BookssTableAdapter();
            this.kitapidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayineviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayimTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfaSayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokMiktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonuDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookLoansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonuDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonuDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookssBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::kütüphane_otomasyonu.Properties.Resources.kk;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(187, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(402, 43);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "KİTAPLIK";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapidDataGridViewTextBoxColumn,
            this.kitapAdiDataGridViewTextBoxColumn,
            this.yazarDataGridViewTextBoxColumn,
            this.yayineviDataGridViewTextBoxColumn,
            this.yayimTarihiDataGridViewTextBoxColumn,
            this.sayfaSayisiDataGridViewTextBoxColumn,
            this.stokMiktariDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.booksBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 340);
            this.dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(22, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kütüphaneOtomasyonuDataSet8
            // 
            this.kütüphaneOtomasyonuDataSet8.DataSetName = "kütüphaneOtomasyonuDataSet8";
            this.kütüphaneOtomasyonuDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookLoansBindingSource
            // 
            this.bookLoansBindingSource.DataMember = "BookLoans";
            this.bookLoansBindingSource.DataSource = this.kütüphaneOtomasyonuDataSet8;
            // 
            // bookLoansTableAdapter
            // 
            this.bookLoansTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(620, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 42);
            this.button3.TabIndex = 15;
            this.button3.Text = "Arama";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // kütüphaneOtomasyonuDataSet13
            // 
            this.kütüphaneOtomasyonuDataSet13.DataSetName = "kütüphaneOtomasyonuDataSet13";
            this.kütüphaneOtomasyonuDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.kütüphaneOtomasyonuDataSet13;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // kütüphaneOtomasyonuDataSet15
            // 
            this.kütüphaneOtomasyonuDataSet15.DataSetName = "kütüphaneOtomasyonuDataSet15";
            this.kütüphaneOtomasyonuDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookssBindingSource
            // 
            this.bookssBindingSource.DataMember = "Bookss";
            this.bookssBindingSource.DataSource = this.kütüphaneOtomasyonuDataSet15;
            // 
            // bookssTableAdapter
            // 
            this.bookssTableAdapter.ClearBeforeFill = true;
            // 
            // kitapidDataGridViewTextBoxColumn
            // 
            this.kitapidDataGridViewTextBoxColumn.DataPropertyName = "kitap_id";
            this.kitapidDataGridViewTextBoxColumn.HeaderText = "kitap_id";
            this.kitapidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapidDataGridViewTextBoxColumn.Name = "kitapidDataGridViewTextBoxColumn";
            this.kitapidDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitapidDataGridViewTextBoxColumn.Width = 125;
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
            // kitaplık
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "kitaplık";
            this.Text = "kitaplık";
            this.Load += new System.EventHandler(this.kitaplık_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonuDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookLoansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonuDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonuDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookssBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private kütüphaneOtomasyonuDataSet8 kütüphaneOtomasyonuDataSet8;
        private System.Windows.Forms.BindingSource bookLoansBindingSource;
        private kütüphaneOtomasyonuDataSet8TableAdapters.BookLoansTableAdapter bookLoansTableAdapter;
        private System.Windows.Forms.Button button3;
        private kütüphaneOtomasyonuDataSet13 kütüphaneOtomasyonuDataSet13;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private kütüphaneOtomasyonuDataSet13TableAdapters.BooksTableAdapter booksTableAdapter;
        private kütüphaneOtomasyonuDataSet15 kütüphaneOtomasyonuDataSet15;
        private System.Windows.Forms.BindingSource bookssBindingSource;
        private kütüphaneOtomasyonuDataSet15TableAdapters.BookssTableAdapter bookssTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayineviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayimTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfaSayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokMiktariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
    }
}