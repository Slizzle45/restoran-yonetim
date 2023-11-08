namespace RestoranYonetim
{
    partial class FormMasaEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMasaAdi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cbKapasite = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masa Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kapasite";
            // 
            // tbMasaAdi
            // 
            this.tbMasaAdi.Location = new System.Drawing.Point(145, 24);
            this.tbMasaAdi.Name = "tbMasaAdi";
            this.tbMasaAdi.Size = new System.Drawing.Size(213, 20);
            this.tbMasaAdi.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(588, 254);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cbKapasite
            // 
            this.cbKapasite.DisplayMember = "secilenDeger";
            this.cbKapasite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKapasite.FormattingEnabled = true;
            this.cbKapasite.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbKapasite.Location = new System.Drawing.Point(145, 78);
            this.cbKapasite.Name = "cbKapasite";
            this.cbKapasite.Size = new System.Drawing.Size(83, 21);
            this.cbKapasite.TabIndex = 1;
            this.cbKapasite.ValueMember = "secilenDeger";
            this.cbKapasite.SelectedIndexChanged += new System.EventHandler(this.cbKapasite_SelectedIndexChanged);
            // 
            // FormMasaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 301);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cbKapasite);
            this.Controls.Add(this.tbMasaAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMasaEkle";
            this.Text = "FormMasaEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMasaAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cbKapasite;
    }
}