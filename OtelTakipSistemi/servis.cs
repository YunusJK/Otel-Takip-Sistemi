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
    public partial class servis : Form
    {
        public servis()
        {
            InitializeComponent();
        }

        private void servis_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Emin misiniz ?","Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Teknik ekiplerimize iletildi.");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Vazgeçildi");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myaccount my2 = new myaccount();
            my2.Show();
            this.Hide();
        }
    }
}
