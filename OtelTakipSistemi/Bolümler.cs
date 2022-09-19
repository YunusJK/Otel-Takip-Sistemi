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
    public partial class Bolümler : Form
    {
        public Bolümler()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OdaKonum oKnm = new OdaKonum();
            oKnm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OdaKayit oKyt = new OdaKayit();
            oKyt.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OdaCikis oCks = new OdaCikis();
            oCks.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            servis srv = new servis();
            srv.Show();
            this.Hide();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            myaccount my1 = new myaccount();
            my1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frmCks = new Form1();
            frmCks.Show();
            this.Hide();
        }
    }
}
