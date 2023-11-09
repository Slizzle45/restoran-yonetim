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
        Urunler secilenSatir = new Urunler();
        Siparisler siparis = new Siparisler();

        List<Urunler> listUrun = new List<Urunler>();
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
            dataGridViewUrunDetay.Rows.Clear();
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
            
            listUrun.Add(secilenUrun);
            SiparisListele(listUrun);
        }

        private void SiparisListele(List<Urunler> listUrun)
        {
            dataGridViewUrunDetay.DataSource = listUrun;
            dataGridViewUrunDetay.Refresh();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewUrunDetay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if(e != null)
            {
                DataGridViewRow row = dataGridViewUrunDetay.Rows[e.RowIndex];

                string deger = row.Cells[2].Value.ToString();

                secilenSatir = urunManager.Bul(deger);
            }
            
        }

        private void btnSatirSil_Click(object sender, EventArgs e)
        {
            listUrun.RemoveAt(listUrun.Count - 1);
            SiparisListele(listUrun);

            //MessageBox.Show(urunManager.Sil(secilenSatir.UrunlerID));
            
        }
    }
}
