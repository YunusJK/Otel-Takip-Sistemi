using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelTakipSistemi
{
    public partial class myaccount : Form
    {
        public myaccount()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            servis srv = new servis();
            srv.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bolümler blmAccount = new Bolümler();
            blmAccount.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sikayet skyt = new sikayet();
            skyt.Show();
            this.Hide();
        }
    }
}
