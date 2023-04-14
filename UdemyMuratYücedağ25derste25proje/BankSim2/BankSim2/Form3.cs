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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-972PD8E\SQLEXPRESS;Initial Catalog=DbBankaTest;Integrated Security=True");
        SqlCommand komut;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bag.Open();
            komut = new SqlCommand("insert into TblKisiler (Ad,Soyad,Tc,Telefon,HesapNo,Sifre) values (@p1,@p2,@p3,@p4,@p5,@p6)", bag);

            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", maskedTc.Text);
            komut.Parameters.AddWithValue("@p4", MaskTel.Text);
            komut.Parameters.AddWithValue("@p5", MskHesapNo.Text);
            komut.Parameters.AddWithValue("@p6", txtSifre.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Müşteri Kaydedildi");
            bag.Close();


        }

        private void BtnHesapNo_Click(object sender, EventArgs e)
        {
            Random rast = new Random();
            int sayi = rast.Next(100000, 1000000);
            MskHesapNo.Text = sayi.ToString();
        }
    }
}
