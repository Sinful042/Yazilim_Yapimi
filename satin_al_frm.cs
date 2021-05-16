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
    public partial class satin_al_frm : Form
    {
        public string alici_kullanici_adi,satici_kullanici_adi;
        public string para;
        int harcanan_para,giden_para,total_para;
        string istek_ürün,urun_birim;
        int istek_miktar, kalan_miktar;
        int olan_miktar;
        

        public satin_al_frm()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=odev1234.mdb");
        DataTable tablo = new DataTable();
        private void cikis_btn_Click(object sender, EventArgs e)
        {
            ana_fr ana = new ana_fr();
            ana.Kullanici_adi = alici_kullanici_adi;
            ana.Para = para;
            ana.Show();
            this.Hide();
        }

        private void satin_al_frm_Load(object sender, EventArgs e)
        {
            lbl_para.Text = para;
            Listeleme();
        }

        private void Listeleme()
        {
            baglanti.Open();
            OleDbDataAdapter liste = new OleDbDataAdapter("select  *from Urunler", baglanti);
            liste.Fill(tablo);
            dataGridView1.DataSource = tablo;
            dataGridView1.ReadOnly = true;
            baglanti.Close();

        }

        private void satın_al_btn_Click(object sender, EventArgs e)
        {
            istek_miktar = Convert.ToInt32(textBox1.Text);
            istek_ürün = dataGridView1.CurrentRow.Cells["UrunAdi"].Value.ToString();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Select *from Satis where UrunAdi = '" + istek_ürün + "' ORDER BY UrunFiyat ASC");
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (istek_miktar<=Convert.ToInt32(oku["sUrunMiktar"].ToString()) && Convert.ToInt32(oku["sUrunMiktar"].ToString())>0)
                {
                    harcanan_para = istek_miktar * (Convert.ToInt32(oku["UrunFiyat"].ToString()));
                    //para kontrol
                    satici_kullanici_adi = oku["KullaniciAdi"].ToString();
                    urun_birim = oku["UrunBirim"].ToString();
                    baglanti.Close();
                    Para_gonder(satici_kullanici_adi,harcanan_para);
                    Para_cikar(alici_kullanici_adi, harcanan_para);
                    urun_ekle(alici_kullanici_adi, istek_miktar.ToString(), istek_ürün, urun_birim);
                    satistan_cikar(istek_ürün, satici_kullanici_adi, istek_miktar);
                    MessageBox.Show("Satın Alım Gerçekleştirilmiştir", "Tamam");
                    break;
                    
                }
                

            }


        }
        private void Para_gonder(string satici_Kullanici_adi,int gelen_para)
        {
            
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select *from Kullanici", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["KullaniciAdi"].ToString()==satici_Kullanici_adi)
                {

                    total_para = Convert.ToInt32(oku["Cuzdan"].ToString());
                    break;
                }

            }
            gelen_para += total_para;
            OleDbCommand komut_2 = new OleDbCommand("update Kullanici set Cuzdan = '" + gelen_para.ToString() + "' where KullaniciAdi = '" + satici_Kullanici_adi + "'", baglanti);
            komut_2.ExecuteNonQuery();
            baglanti.Close();
            

        }
        private void Para_cikar(string Kullanici_adi,int para)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select *from Kullanici", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["KullaniciAdi"].ToString() == Kullanici_adi)
                {

                    total_para = Convert.ToInt32(oku["Cuzdan"].ToString());
                    break;
                }

            }
            total_para -= para;
            OleDbCommand komut_2 = new OleDbCommand("update Kullanici set Cuzdan = '" + total_para.ToString() + "' where KullaniciAdi = '" + Kullanici_adi + "'", baglanti);
            komut_2.ExecuteNonQuery();
            baglanti.Close();
        }
        private void urun_ekle(string Kullanici_adi,string alinan_miktar,string urunAd,string Birim)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into kUrun(UrunAdi,UrunMiktar,KullaniciU,UrunBirim) values('" + urunAd + "','" + alinan_miktar + "','" + Kullanici_adi + "','" + Birim + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            

        }
        private void satistan_cikar(string Urunadi,string Kullanici_Adi,int alinan_miktar)
        {
            baglanti.Open();
            OleDbCommand sorgu = new OleDbCommand("select *from Satis where UrunAdi= '"+Urunadi+"'",baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                if (oku["KullaniciAdi"].ToString()==Kullanici_Adi)
                {
                    olan_miktar = Convert.ToInt32(oku["SUrunMiktar"].ToString());
                    break;
                }
            }
            olan_miktar -= alinan_miktar;
            OleDbCommand komut = new OleDbCommand("uptade Satis set SUrunMiktar='" + olan_miktar.ToString() + "' where KullaniciAdi='" + Kullanici_Adi + "' and UrunAdi='" + Urunadi + "'", baglanti);
            baglanti.Close();
        }
    }
}
