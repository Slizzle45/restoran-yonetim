namespace RestoranYonetim
{
    partial class FormAnaSayfa
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
            if(disposing && (components != null))
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnHesapKes = new System.Windows.Forms.Button();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.btnSiparisSil = new System.Windows.Forms.Button();
            this.btnMasaEkle = new System.Windows.Forms.Button();
            this.btnMasaSil = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsUrunler = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMasaRezerve = new System.Windows.Forms.Button();
            this.btnMasaRezerveKaldir = new System.Windows.Forms.Button();
            this.btnPasif = new System.Windows.Forms.Button();
            this.labelefe = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(975, 262);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Masalar";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(962, 236);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btnHesapKes);
            this.groupBox2.Location = new System.Drawing.Point(13, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1325, 421);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Masa Özeti";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(814, 385);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnHesapKes
            // 
            this.btnHesapKes.BackColor = System.Drawing.Color.ForestGreen;
            this.btnHesapKes.Location = new System.Drawing.Point(839, 349);
            this.btnHesapKes.Name = "btnHesapKes";
            this.btnHesapKes.Size = new System.Drawing.Size(480, 56);
            this.btnHesapKes.TabIndex = 1;
            this.btnHesapKes.Text = "Hesap Kes";
            this.btnHesapKes.UseVisualStyleBackColor = false;
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSiparisEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSiparisEkle.Location = new System.Drawing.Point(1013, 28);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(141, 78);
            this.btnSiparisEkle.TabIndex = 4;
            this.btnSiparisEkle.Text = "Sipariş Ekle";
            this.btnSiparisEkle.UseVisualStyleBackColor = false;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // btnSiparisSil
            // 
            this.btnSiparisSil.BackColor = System.Drawing.Color.DarkRed;
            this.btnSiparisSil.Location = new System.Drawing.Point(1013, 128);
            this.btnSiparisSil.Name = "btnSiparisSil";
            this.btnSiparisSil.Size = new System.Drawing.Size(141, 78);
            this.btnSiparisSil.TabIndex = 6;
            this.btnSiparisSil.Text = "Sipariş Sil";
            this.btnSiparisSil.UseVisualStyleBackColor = false;
            // 
            // btnMasaEkle
            // 
            this.btnMasaEkle.Location = new System.Drawing.Point(1197, 44);
            this.btnMasaEkle.Name = "btnMasaEkle";
            this.btnMasaEkle.Size = new System.Drawing.Size(141, 47);
            this.btnMasaEkle.TabIndex = 7;
            this.btnMasaEkle.Text = "Masa Ekle";
            this.btnMasaEkle.UseVisualStyleBackColor = true;
            this.btnMasaEkle.Click += new System.EventHandler(this.btnMasaEkle_Click);
            // 
            // btnMasaSil
            // 
            this.btnMasaSil.Location = new System.Drawing.Point(1197, 146);
            this.btnMasaSil.Name = "btnMasaSil";
            this.btnMasaSil.Size = new System.Drawing.Size(141, 43);
            this.btnMasaSil.TabIndex = 8;
            this.btnMasaSil.Text = "Masa Sil";
            this.btnMasaSil.UseVisualStyleBackColor = true;
            this.btnMasaSil.Click += new System.EventHandler(this.btnMasaSil_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem,
            this.tsUrunler});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anasayfaToolStripMenuItem
            // 
            this.anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            this.anasayfaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.anasayfaToolStripMenuItem.Text = "Anasayfa";
            // 
            // tsUrunler
            // 
            this.tsUrunler.Name = "tsUrunler";
            this.tsUrunler.Size = new System.Drawing.Size(58, 20);
            this.tsUrunler.Text = "Ürünler";
            this.tsUrunler.Click += new System.EventHandler(this.tsUrunler_Click);
            // 
            // btnMasaRezerve
            // 
            this.btnMasaRezerve.Location = new System.Drawing.Point(1013, 253);
            this.btnMasaRezerve.Name = "btnMasaRezerve";
            this.btnMasaRezerve.Size = new System.Drawing.Size(108, 31);
            this.btnMasaRezerve.TabIndex = 10;
            this.btnMasaRezerve.Text = "Masa Rezerve";
            this.btnMasaRezerve.UseVisualStyleBackColor = true;
            this.btnMasaRezerve.Click += new System.EventHandler(this.btnMasaRezerve_Click);
            // 
            // btnMasaRezerveKaldir
            // 
            this.btnMasaRezerveKaldir.Location = new System.Drawing.Point(1127, 253);
            this.btnMasaRezerveKaldir.Name = "btnMasaRezerveKaldir";
            this.btnMasaRezerveKaldir.Size = new System.Drawing.Size(108, 31);
            this.btnMasaRezerveKaldir.TabIndex = 11;
            this.btnMasaRezerveKaldir.Text = "Rezervasyon Kaldır";
            this.btnMasaRezerveKaldir.UseVisualStyleBackColor = true;
            this.btnMasaRezerveKaldir.Click += new System.EventHandler(this.btnMasaRezerveKaldir_Click);
            // 
            // btnPasif
            // 
            this.btnPasif.Location = new System.Drawing.Point(1013, 216);
            this.btnPasif.Name = "btnPasif";
            this.btnPasif.Size = new System.Drawing.Size(108, 31);
            this.btnPasif.TabIndex = 12;
            this.btnPasif.Text = "Masa Pasif";
            this.btnPasif.UseVisualStyleBackColor = true;
            // 
            // labelefe
            // 
            this.labelefe.AutoSize = true;
            this.labelefe.Location = new System.Drawing.Point(1197, 216);
            this.labelefe.Name = "labelefe";
            this.labelefe.Size = new System.Drawing.Size(0, 13);
            this.labelefe.TabIndex = 13;
            // 
            // FormAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.labelefe);
            this.Controls.Add(this.btnPasif);
            this.Controls.Add(this.btnMasaRezerveKaldir);
            this.Controls.Add(this.btnMasaRezerve);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnMasaSil);
            this.Controls.Add(this.btnMasaEkle);
            this.Controls.Add(this.btnSiparisSil);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAnaSayfa";
            this.Text = "Restoran Yönetim Uygulaması";
            this.Load += new System.EventHandler(this.FormAnaSayfa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.Button btnSiparisSil;
        private System.Windows.Forms.Button btnHesapKes;
        private System.Windows.Forms.Button btnMasaEkle;
        private System.Windows.Forms.Button btnMasaSil;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsUrunler;
        private System.Windows.Forms.Button btnMasaRezerve;
        private System.Windows.Forms.Button btnMasaRezerveKaldir;
        private System.Windows.Forms.Button btnPasif;
        private System.Windows.Forms.Label labelefe;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}