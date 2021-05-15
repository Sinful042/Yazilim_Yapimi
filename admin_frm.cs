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
      
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=odev1234.mdb");
       
        public admin_frm()
        {
            
        InitializeComponent();
        }

        private void para_list_btn_Click(object sender, EventArgs e)
        {
            para_ist_frm admin_sayfa = new para_ist_frm();
            admin_sayfa.Show();
            this.Hide();
        }

        private void cikisadmin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cikis_btnadmin_Click(object sender, EventArgs e)
        {
            Giris_frm admincikis = new Giris_frm();
            admincikis.Show();
            this.Hide();
        }

        private void sts_list_btn_Click(object sender, EventArgs e)
        {
            urn_ist_frm satis_sayfa = new urn_ist_frm();
            satis_sayfa.Show();
            this.Hide();
        }

        private void admin_frm_Load(object sender, EventArgs e)
        {
           
        }

        private void admin_lbl_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewSo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
