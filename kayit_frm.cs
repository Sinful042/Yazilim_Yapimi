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
    public partial class kayit_frm : Form
    {
        bool kayit_yapildi = true;
        bool kullani_adi_yok = true;
        public kayit_frm()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti=new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=odev1234.mdb");
        private void kayit_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is TextBox)
                {
                    if (Controls[i].Text=="")
                    {
                        MessageBox.Show("Eksik Bilgi Girdiniz.", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        kayit_yapildi = false;
                        break;
                        

                    }

                }
                else
                {
                    kayit_yapildi = true;
                }
                
            }
            baglanti.Open();
            OleDbCommand sorgu = new OleDbCommand("select *from Kullanici", baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                if (kullanici_adi.Text == oku["KullaniciAdi"].ToString())
                {
                    MessageBox.Show("Kullanici Adi Kullanılmakta.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    kullani_adi_yok = false;
                    baglanti.Close();
                    break;
                    
                }
                else
                {
                    kullani_adi_yok = true;
                    baglanti.Close();
                    break;
                }
            }
            
            if (kayit_yapildi && kullani_adi_yok)
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("insert into Kullanici(Ad,Soyad,KullaniciAdi,Parola,TC,ePosta,Adres,Telefon) values('" + ad.Text + "','" + soyad.Text + "','" + kullanici_adi.Text + "','" + sifre.Text + "','" + tc.Text + "','" + email.Text + "','" + adres.Text + "','" + telefon.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                Giris_frm giris = new Giris_frm();
                giris.Show();
                this.Hide();
            }
            


            
            
        }

        
    }
}
