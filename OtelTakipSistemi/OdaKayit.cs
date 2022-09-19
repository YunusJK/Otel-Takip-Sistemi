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
    public partial class OdaKayit : Form
    {
        public OdaKayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oda kaydınız yapılmıştır.İyi günler dileriz.");
            OdaKonum oknm = new OdaKonum();
            oknm.Show();
            this.Hide();
            if (comboBox1.SelectedIndex == 1)
            {
                label1.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bolümler blm3 = new Bolümler();
            blm3.Show();
            this.Hide();    
        }
    }
}
