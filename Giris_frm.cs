﻿
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
    public partial class Giris_frm : Form
    {
        bool giris = false;
        public Giris_frm()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=odev1234.mdb");
        private void kayit_btn_Click(object sender, EventArgs e)
        {
            kayit_frm kayit = new kayit_frm();
            kayit.Show();

            this.Hide();

        }

        private void gris_btn_Click(object sender, EventArgs e)
        {

            baglanti.Close();
            baglanti.Open();
            OleDbCommand sorgu = new OleDbCommand("select *from Kullanici", baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                if (oku["KullaniciAdi"].ToString() == kullacini_txt.Text && oku["Parola"].ToString() == sifre_txt.Text && oku["Yetki"].ToString() == "Admin")
                {
                    giris = true;

                    admin_frm admin_ana = new admin_frm();
                    admin_ana.Show();
                    this.Hide();
                    break;
                }
                else if (oku["KullaniciAdi"].ToString() == kullacini_txt.Text && oku["Parola"].ToString() == sifre_txt.Text && oku["Yetki"].ToString() == "Kullanici")
                {

                    giris = true;
                    ana_fr ana_Sayfa = new ana_fr();
                    ana_Sayfa.Kullanici_adi = oku["KullaniciAdi"].ToString();
                    ana_Sayfa.Para = oku["Cuzdan"].ToString();
                    ana_Sayfa.Show();
                    this.Hide();
                    break;
                }

            }
            if (kullacini_txt.Text == " " || sifre_txt.Text == "")
            {
                MessageBox.Show("Kullani Adi veya şifre boş geçilemez", "Tamam");
            }
            else if (!giris)
            {
                MessageBox.Show("Kullanici Adi veya Şifre Yanlış", "Tamam");
            }

            baglanti.Close();



        }

        private void Giris_frm_Load(object sender, EventArgs e)
        {

        }

        private void kullacini_txt_Enter(object sender, EventArgs e)
        {
            if (kullacini_txt.Text == "Kullanıcı-Adı")
            {
                kullacini_txt.Text = "";
                kullacini_txt.ForeColor = Color.Black;

            }
        }

        private void kullacini_txt_Leave(object sender, EventArgs e)
        {
            if (kullacini_txt.Text == "")
            {
                kullacini_txt.Text = "Kullanıcı-Adı";
                kullacini_txt.ForeColor = Color.Silver;
            }
        }

        private void sifre_txt_Enter(object sender, EventArgs e)
        {
            if (sifre_txt.Text == "Parola")
            {
                sifre_txt.Text = "";
                sifre_txt.PasswordChar = '*';
                sifre_txt.ForeColor = Color.Black;
            }
        }
        char? passwordgiris = null;
        private void sifre_txt_Leave(object sender, EventArgs e)
        {
            if (sifre_txt.Text == "")
            {
                sifre_txt.Text = "Parola";
                sifre_txt.PasswordChar = Convert.ToChar(passwordgiris);
                sifre_txt.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
