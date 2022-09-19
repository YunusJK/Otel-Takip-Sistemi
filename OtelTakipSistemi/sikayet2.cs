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
    public partial class sikayet2 : Form
    {
        public sikayet2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Şikayet Etmek İstediğinize Emin misiniz ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Ekiplerimiz en kısa zamanda sizinle iletişime geçecektir.");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Vazgeçildi");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sikayet skyt5 = new sikayet();
            skyt5.Show();
            this.Hide();
        }
    }
}
