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
    public partial class OneriVer : Form
    {
        public OneriVer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sikayet skytOneriVer = new sikayet();
            skytOneriVer.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Öneri vermek istediğinize emin misiniz ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Önerinizi en kısa zamanda değerlendireceğiz.");
            }
            else
            {
                MessageBox.Show("İptal edildi");
            }
        }
    }
}
