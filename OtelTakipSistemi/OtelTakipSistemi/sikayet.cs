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
    public partial class sikayet : Form
    {
        public sikayet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sikayet2 skyt2 = new sikayet2();
            skyt2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sikayetler skytgelen = new sikayetler();
            skytgelen.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OneriVer onVeri = new OneriVer();
            onVeri.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OneriVer onVer = new OneriVer();
            onVer.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            myaccount hspGeri = new myaccount();
            hspGeri.Show();
            this.Hide();
        }
    }
}
