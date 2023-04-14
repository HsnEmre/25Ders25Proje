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

namespace BiletRezervasyonSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-972PD8E\SQLEXPRESS;Initial Catalog=TestYolcuBilet;Integrated Security=True");
        private void btnkydet_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand kom = new SqlCommand("insert into TblYolcuBilgi (Ad,Soyad,Telefon,Tc,Cinsiyet,mail) values (@p1,@p2,@p3,@p4,@p5,@p6)", bag);
            kom.Parameters.AddWithValue("@p1", txtad.Text);
            kom.Parameters.AddWithValue("@p2", txtsoyad.Text);
            kom.Parameters.AddWithValue("@p3", msktel.Text);
            kom.Parameters.AddWithValue("@p4", msktc.Text);
            kom.Parameters.AddWithValue("@p5", cmbcins.Text);
            kom.Parameters.AddWithValue("@p6", txtmail.Text);
            kom.ExecuteNonQuery();

           
            bag.Close();
            MessageBox.Show("Yolcu bilgisi Sisteme Kaydedildi");

        }
    }
}
