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
    public partial class FormUrunEkle : Form
    {
        UrunManager urunManager = new UrunManager();

        public FormUrunEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string urunAdi = tbUrunAdi.Text.ToString();
            string kategori = cbKategori.SelectedValue.ToString();
            int fiyat = Convert.ToInt32(tbFiyat.Text);
            string aciklama = tbAciklama.Text.ToString().ToLower();

            MessageBox.Show(urunManager.Kaydet(urunAdi, kategori, fiyat, aciklama));
        }

        private void FormUrunEkle_Load(object sender, EventArgs e)
        {
            List<string> kategoriler = new List<string>();
            kategoriler.Add("Ana Yemekler");
            kategoriler.Add("Tatlılar");
            kategoriler.Add("Meşrubatlar");
            kategoriler.Add("Diğer");
            cbKategori.DataSource = kategoriler;
        }
    }
}
