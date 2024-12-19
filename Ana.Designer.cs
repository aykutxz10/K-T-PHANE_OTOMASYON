namespace kütüphane_otomasyonu
{
    partial class Ana
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
            this.kitapAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayineviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayimTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfaSayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokMiktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kütüphaneOtomasyonuDataSet1 = new kütüphane_otomasyonu.kütüphaneOtomasyonuDataSet1();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kütüphaneOtomasyonuDataSet = new kütüphane_otomasyonu.kütüphaneOtomasyonuDataSet();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.booksTableAdapter = new kütüphane_otomasyonu.kütüphaneOtomasyonuDataSetTableAdapters.BooksTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.booksTableAdapter1 = new kütüphane_otomasyonu.kütüphaneOtomasyonuDataSet1TableAdapters.BooksTableAdapter();
            this.kütüphaneOtomasyonuDataSet2 = new kütüphane_otomasyonu.kütüphaneOtomasyonuDataSet2();
            this.bookLoansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookLoansTableAdapter = new kütüphane_otomasyonu.kütüphaneOtomasyonuDataSet2TableAdapters.BookLoansTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.kütüphaneOtomasyonuDataSet17 = new kütüphane_otomasyonu.kütüphaneOtomasyonuDataSet17();
            this.bookssBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookssTableAdapter = new kütüphane_otomasyonu.kütüphaneOtomasyonuDataSet17TableAdapters.BookssTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonuDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookLoansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonuDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookssBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapAdiDataGridViewTextBoxColumn,
            this.yazarDataGridViewTextBoxColumn,
            this.yayineviDataGridViewTextBoxColumn,
            this.yayimTarihiDataGridViewTextBoxColumn,
            this.sayfaSayisiDataGridViewTextBoxColumn,
            this.stokMiktariDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.booksBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(313, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(475, 360);
            this.dataGridView1.TabIndex = 0;
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
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "Books";
            this.booksBindingSource1.DataSource = this.kütüphaneOtomasyonuDataSet1;
            // 
            // kütüphaneOtomasyonuDataSet1
            // 
            this.kütüphaneOtomasyonuDataSet1.DataSetName = "kütüphaneOtomasyonuDataSet1";
            this.kütüphaneOtomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.kütüphaneOtomasyonuDataSet;
            // 
            // kütüphaneOtomasyonuDataSet
            // 
            this.kütüphaneOtomasyonuDataSet.DataSetName = "kütüphaneOtomasyonuDataSet";
            this.kütüphaneOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.Location = new System.Drawing.Point(149, 170);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(158, 27);
            this.textBox5.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(383, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(365, 38);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "KitapAdi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yazar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yayinevi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "SayfaSayisi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(20, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "StokMiktari :";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(149, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 27);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(149, 92);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 27);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(149, 134);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(158, 27);
            this.textBox4.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(149, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 27);
            this.textBox1.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(170, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 42);
            this.button3.TabIndex = 14;
            this.button3.Text = "Arama";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(20, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "YayimTarihi:";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox6.Location = new System.Drawing.Point(149, 207);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(158, 27);
            this.textBox6.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(316, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "ID";
            // 
            // booksTableAdapter1
            // 
            this.booksTableAdapter1.ClearBeforeFill = true;
            // 
            // kütüphaneOtomasyonuDataSet2
            // 
            this.kütüphaneOtomasyonuDataSet2.DataSetName = "kütüphaneOtomasyonuDataSet2";
            this.kütüphaneOtomasyonuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookLoansBindingSource
            // 
            this.bookLoansBindingSource.DataMember = "BookLoans";
            this.bookLoansBindingSource.DataSource = this.kütüphaneOtomasyonuDataSet2;
            // 
            // bookLoansTableAdapter
            // 
            this.bookLoansTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::kütüphane_otomasyonu.Properties.Resources.kk;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(0, 396);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 42);
            this.button4.TabIndex = 20;
            this.button4.Text = "Geri";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // kütüphaneOtomasyonuDataSet17
            // 
            this.kütüphaneOtomasyonuDataSet17.DataSetName = "kütüphaneOtomasyonuDataSet17";
            this.kütüphaneOtomasyonuDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookssBindingSource
            // 
            this.bookssBindingSource.DataMember = "Bookss";
            this.bookssBindingSource.DataSource = this.kütüphaneOtomasyonuDataSet17;
            // 
            // bookssTableAdapter
            // 
            this.bookssTableAdapter.ClearBeforeFill = true;
            // 
            // Ana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Ana";
            this.Text = "Ana";
            this.Load += new System.EventHandler(this.Ana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonuDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookLoansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonuDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookssBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private kütüphaneOtomasyonuDataSet kütüphaneOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private kütüphaneOtomasyonuDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayineviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayimTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfaSayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokMiktariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private kütüphaneOtomasyonuDataSet1 kütüphaneOtomasyonuDataSet1;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private kütüphaneOtomasyonuDataSet1TableAdapters.BooksTableAdapter booksTableAdapter1;
        private kütüphaneOtomasyonuDataSet2 kütüphaneOtomasyonuDataSet2;
        private System.Windows.Forms.BindingSource bookLoansBindingSource;
        private kütüphaneOtomasyonuDataSet2TableAdapters.BookLoansTableAdapter bookLoansTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button4;
        private kütüphaneOtomasyonuDataSet17 kütüphaneOtomasyonuDataSet17;
        private System.Windows.Forms.BindingSource bookssBindingSource;
        private kütüphaneOtomasyonuDataSet17TableAdapters.BookssTableAdapter bookssTableAdapter;
    }
}