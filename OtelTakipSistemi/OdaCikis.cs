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
    public partial class OdaCikis : Form
    {
        public OdaCikis()
        {
            InitializeComponent();
        }

        private void OdaCikis_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bolümler blm = new Bolümler();
            blm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Oda çıkışı yapmak istediğinize emin misiniz ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Oda çıkışınız yapılmıştır.İyi günler dileriz");
            }
            else
            {
                MessageBox.Show("İptal edildi");
            }
        }
    }
}
