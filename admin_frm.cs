using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Ödevi
{
    public partial class admin_frm : Form
    {
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

        

        

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            Giris_frm giris = new Giris_frm();
            giris.Show();
            this.Hide();

        }

        private void satis_btn_Click(object sender, EventArgs e)
        {
            satis_ist_frm satis = new satis_ist_frm();
            satis.Show();
            this.Hide();
        }

        private void admin_frm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
