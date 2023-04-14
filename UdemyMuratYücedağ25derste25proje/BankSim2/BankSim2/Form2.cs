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
    public partial class Form2 : Form
    {

        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-972PD8E\SQLEXPRESS;Initial Catalog=DbBankaTest;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }
        SqlCommand komut;
        SqlDataReader dr;

        public string Hesap;
        private void Form2_Load(object sender, EventArgs e)
        {
            bag.Open();
            lblHesapNo.Text = Hesap;
            komut = new SqlCommand("select * from TblKisiler where Hesapno=@p1", bag);
            komut.Parameters.AddWithValue("@p1", Hesap);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladSoyad.Text = dr[1] + " " + dr[2];
                lblTel.Text = dr[4].ToString();
                lblTc.Text = dr[3].ToString();

            }
            bag.Close();
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            bag.Open();
            komut = new SqlCommand("update TblHesap set Bakiye = Bakiye  + @p1 where HesapNo = @p2", bag);
            komut.Parameters.AddWithValue("@p1", decimal.Parse(txttutar.Text));
            komut.Parameters.AddWithValue("@p2", MskHesapNo.Text);
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Havale Yapıldı");

        }
    }
}
