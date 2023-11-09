using RestoranYonetim.BLL.Manager;
using RestoranYonetim.DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranYonetim
{
    public partial class FormSiparisAl : Form
    {
        Masalar secilenMasa = new Masalar();
        int urunID;

        UrunManager urunManager = new UrunManager();
        Urunler secilenUrun = new Urunler();

        //public FormSiparisAl()
        //{
        //    InitializeComponent();
        //}

        public FormSiparisAl(Masalar masa)//Seçili masaya işlem yapılacak
        {
            secilenMasa = masa;
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenUrun.UrunAdi = comboBox1.SelectedValue.ToString();
            secilenUrun = urunManager.Bul(secilenUrun.UrunAdi);
        }

        private void FormSiparisAl_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = urunManager.UrunListesi();
            toolStripStatusLabel1.Text += secilenMasa.MasaAdi;
        }
    }
}
