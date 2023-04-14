using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankSim2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-972PD8E\SQLEXPRESS;Initial Catalog=DbBankaTest;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        SqlDataReader dr;
        private void lnkKayıtol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            bag.Open();
            komut = new SqlCommand("select * from TblKisiler where HesapNo=@p1 and Sifre=@p2",bag);
            komut.Parameters.AddWithValue("@p1", mskHesap.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form2 fr = new Form2();
                fr.Hesap = mskHesap.Text;
                fr.Show();
            }
            else
            {
                MessageBox.Show("HesapNo veya Şifre Yanlış");
            }
            bag.Close();
        }
    }
}
