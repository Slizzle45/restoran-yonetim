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
    public partial class FormUrunler : Form
    {

        UrunManager urunManager = new UrunManager();

        public FormUrunler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormUrunEkle frmUrunEkle = new FormUrunEkle();
            frmUrunEkle.ShowDialog();
        }

        private void FormUrunler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = urunManager.UrunListesi();
        }
    }
}
