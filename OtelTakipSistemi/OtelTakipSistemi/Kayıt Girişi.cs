using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OtelTakipSistemi
{
    public partial class Kayıt_Girişi : Form
    {
        public Kayıt_Girişi()
        {
            InitializeComponent();
        }

        string baglanti = "provider=microsoft.jet.oledb.4.0;data source=otel.mdb";







        private void button2_Click(object sender, EventArgs e)
        {
            Form1 giris = new Form1();
            giris.Show();
            this.Hide();
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "Insert into kullanicilar (Kullanıcı_Adi,Adi,Soyadi,Telefonno,D_Tarihi,Kimlikno,Cinsiyet,Sifre) " +
                       "values ('" + textBox1.Text + "','" + textBox2.Text + "'," +
                        textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" +
                        textBox6.Text + "','" + checkBox1.Text + "','" + textBox7.Text + "','" +
                        textBox8.Text + "')";

            OleDbConnection b = new OleDbConnection(baglanti);
            OleDbCommand k = new OleDbCommand(sql);
            b.Open();
            k.ExecuteNonQuery();
            b.Close();





            Form1 frm = new Form1();
            frm.Show();
            this.Hide();

        }
       
            
        }

        
    
}
