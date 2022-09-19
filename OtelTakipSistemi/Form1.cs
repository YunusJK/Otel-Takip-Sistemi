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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kayıt_Girişi kyt = new Kayıt_Girişi();
            kyt.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bolümler blm = new Bolümler();
            blm.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //textBox2.PasswordChar= '*';

            if (checkBox1.Checked)
            {
                textBox2.PasswordChar='\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Programdan çıkmak istediğinize emin misiniz ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
