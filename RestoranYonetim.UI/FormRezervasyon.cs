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

namespace RestoranYonetim.UI
{
    public partial class FormRezervasyon : Form
    {
        RezervasyonManager rezervasyonManager = new RezervasyonManager();

        Masalar masa = new Masalar();


        public FormRezervasyon(Masalar masa)
        {
            this.masa = masa;
            InitializeComponent();
        }

        private void FormRezervasyon_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DateTime tarih;
            DateTime pickerTarih = dateTimePicker1.Value;
            DateTime pickerSaat = dateTimePicker2.Value;
            tarih = pickerTarih.Date + pickerSaat.TimeOfDay;
            int rezervasyonSaati = int.Parse(tbSaat.Text);
            int kisiSayisi = cbKisiSayisi.SelectedIndex+1;
            MessageBox.Show(rezervasyonManager.Kaydet(masa.MasaID, tarih, rezervasyonSaati, kisiSayisi));
            masa.Durum = "rezerve";
        }

        
    }
}
