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
    }
}
