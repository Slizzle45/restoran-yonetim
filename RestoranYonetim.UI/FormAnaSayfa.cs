using RestoranYonetim.BLL.Manager;
using RestoranYonetim.DLL;
using RestoranYonetim.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranYonetim
{
    public partial class FormAnaSayfa : Form
    {
        MasaManager masaManager = new MasaManager();
        Button secilenButon = new Button();
        Masalar secilenMasa = new Masalar();

        public FormAnaSayfa()
        {
            InitializeComponent();
        }

        private void FormAnaSayfa_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1_Load(sender, e);
            

        }

        public void flowLayoutPanel1_Load(object sender, EventArgs e)
        {
            

            if(sender.Equals("child"))
            {
                flowLayoutPanel1.Controls.Clear();
            }
            var masalar = masaManager.MasaListesi().ToList();

            foreach(var masa in masalar)
            {
                Button button = new Button();
                button.Text = masa.MasaAdi;
                button.Size = new Size(45, 45);
                if(masa.Durum.Equals("pasif") || masa.Durum.Equals("Pasif"))
                    button.BackColor = Color.DarkRed;
                if(masa.Durum.Equals("rezerve") || masa.Durum.Equals("Rezerve"))
                    button.BackColor = Color.DarkCyan;

                flowLayoutPanel1.Controls.Add(button);
            }

            foreach(Button button in flowLayoutPanel1.Controls)
            {
                button.Click += new EventHandler(button_Click);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            secilenButon = (Button)sender;
            secilenMasa = masaManager.Bul(secilenButon.Text);
            labelefe.Text = secilenMasa.MasaAdi;
            MasaVeriGoster();

        }

        private void MasaVeriGoster()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = masaManager.MasaListesi();
            
        }

        private void tsUrunler_Click(object sender, EventArgs e)
        {
            FormUrunler frmUrunler = new FormUrunler();
            frmUrunler.ShowDialog();
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            FormSiparisAl frmSiparis = new FormSiparisAl(secilenMasa);
            frmSiparis.Show();
        }

        private void btnMasaEkle_Click(object sender, EventArgs e)
        {

            FormMasaEkle frmMasaEkle = new FormMasaEkle(this);
            frmMasaEkle.Show();

        }

        private void btnMasaSil_Click(object sender, EventArgs e)
        {
            MessageBox.Show(masaManager.Sil(secilenMasa.MasaID));
            
            flowLayoutPanel1_Load("child", e);
        }
    }
}
