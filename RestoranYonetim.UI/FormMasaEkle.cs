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
    public partial class FormMasaEkle : Form
    {
        int kapasite = 0;
        public FormMasaEkle()
        {
            InitializeComponent();
        }
        private FormAnaSayfa mainForm = null;
        public FormMasaEkle(Form callingForm)
        {
            mainForm = callingForm as FormAnaSayfa;
            InitializeComponent();
        }

        MasaManager masalar = new MasaManager();
        

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string masaAdi = tbMasaAdi.Text;
            MessageBox.Show(masalar.Kaydet(masaAdi, kapasite, "aktif"));
            sender = "child";

            mainForm.flowLayoutPanel1_Load(sender, e);
        }

        private void cbKapasite_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seciliDeger = cbKapasite.SelectedIndex+1;

            kapasite = seciliDeger;
        }
    }
}
