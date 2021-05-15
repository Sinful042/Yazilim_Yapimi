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
    public partial class urn_ist_frm : Form
    {
        public urn_ist_frm()
        {
            InitializeComponent();
        }

        private void cikissatisonay_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void geri_btnso_Click(object sender, EventArgs e)
        {
            admin_frm stsgeri = new admin_frm();
            stsgeri.Show();
            this.Hide();
        }
    }
}
