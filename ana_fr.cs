using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proje_Ödevi
{
    public partial class ana_fr : Form
    {
        public String Kullanici_adi;
        public string Para;
        public ana_fr()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=odev1234.mdb");
        DataTable tablo = new DataTable();

        private void ana_fr_Load(object sender, EventArgs e)
        {
            kullanici_lbl.Text = Kullanici_adi;
            para_lbl.Text = Para;
            listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Giris_frm giris = new Giris_frm();
            giris.Show();
            this.Hide();

        }
        public void listele()
        {
            baglanti.Open();
            OleDbDataAdapter liste = new OleDbDataAdapter("select UrunKod,Urunkg from kUrun where KullaniciU = '"+Kullanici_adi+"'", baglanti);
            liste.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        private void para_ekle_btn_Click(object sender, EventArgs e)
        {
            para_ekle_frm para_ekle = new para_ekle_frm();
            para_ekle.kullanici_adi = Kullanici_adi;
            para_ekle.ShowDialog();
        }
    }
}
