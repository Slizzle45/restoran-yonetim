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

        UrunManager urunManager = new UrunManager();
        SiparisManager siparisManager = new SiparisManager();
        Urunler secilenUrun = new Urunler();
        Siparisler siparis = new Siparisler();
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
            secilenUrun.UrunAdi = comboBox1.SelectedItem.ToString();
            secilenUrun = urunManager.Bul(secilenUrun.UrunAdi);
        }

        private void FormSiparisAl_Load(object sender, EventArgs e)
        {
            var urunListesi = urunManager.UrunListesi();

            foreach(var urun in urunListesi)
            {
                comboBox1.Items.Add(urun.UrunAdi);
            }
            toolStripStatusLabel1.Text += secilenMasa.MasaAdi;
        }

        private void btnEkle_Click(object sender, EventArgs e)//sipariş ekle
        {
            MessageBox.Show(siparisManager.Kaydet(DateTime.Now, siparis.ToplamFiyat, secilenMasa.MasaID));
            
        }

        private void button1_Click(object sender, EventArgs e)//ürün ekle
        {
            siparis.MasaID = secilenMasa.MasaID;
            siparis.ToplamFiyat += secilenUrun.Fiyat;
        }
    }
}
