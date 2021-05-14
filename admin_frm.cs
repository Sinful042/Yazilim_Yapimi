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
    public partial class admin_frm : Form
    {
        private string para;
        private int şuanki_para;
        private int total_para;
        private int istek_para;
        private string kullanici_adi;
        private string durum;
        public admin_frm()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=odev1234.mdb");
        DataTable tablo = new DataTable();
        private void cikis_btn_Click(object sender, EventArgs e)
        {
            Giris_frm giris = new Giris_frm();
            giris.Show();
            this.Hide();
        }

        private void admin_frm_Load(object sender, EventArgs e)
        {
            Listeleme();

        }
        public void Listeleme()
        {
                baglanti.Open();
                OleDbDataAdapter liste = new OleDbDataAdapter("select  *from Paraekle", baglanti);
                liste.Fill(tablo);
                dataGridView1.DataSource = tablo;
                dataGridView1.ReadOnly = true;
                baglanti.Close();

            
        }

        private void onay_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select *from Paraekle where İstekPekle= '"+dataGridView1.CurrentRow.Cells["İstekPekle"].Value.ToString()+"'",baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            
             while (oku.Read())
            {
                para = oku["İstekPekle"].ToString();
                istek_para = Int32.Parse(para);
            }
            baglanti.Close();

            baglanti.Open();
            OleDbCommand komut_2 = new OleDbCommand("Select *from Kullanici where KullaniciAdi= '"+dataGridView1.CurrentRow.Cells["KullaniciPekle"].Value.ToString() + "'", baglanti);
            OleDbDataReader oku_2 = komut_2.ExecuteReader();
            while (oku_2.Read())
            {
                para = oku_2["Cuzdan"].ToString();
                şuanki_para = Int32.Parse(para);
                total_para = istek_para + şuanki_para;
            }
            baglanti.Close();
            para_güncelle(total_para);
            durum = "Onaylandı";
            kullanici_adi = dataGridView1.CurrentRow.Cells["KullaniciPekle"].Value.ToString();
            Durum_güncelle(kullanici_adi,durum);
            

        }


        public void para_güncelle(int para)
        {
            baglanti.Open();
            OleDbCommand komut_2 = new OleDbCommand("update Kullanici set Cuzdan = '" + para.ToString() + "' where KullaniciAdi = '" + dataGridView1.CurrentRow.Cells["KullaniciPekle"].Value.ToString() + "'", baglanti);
            komut_2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Onaylama Başarılı", "Tamam");
        }
        public void Durum_güncelle(String Kullanici_adi,string durum)
        {
            baglanti.Open();
            OleDbCommand komut_3 = new OleDbCommand("update Paraekle set Durum= '" +durum+"' where KullaniciPekle = '" + Kullanici_adi + "'",baglanti);
            komut_3.ExecuteReader();
            baglanti.Close();
            tablo.Clear();
            Listeleme();

        }

        private void onaylama_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand sorgu = new OleDbCommand("select *from Paraekle where Durum= '" + dataGridView1.CurrentRow.Cells["Durum"].Value.ToString() + "'", baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
        }
    }
}
