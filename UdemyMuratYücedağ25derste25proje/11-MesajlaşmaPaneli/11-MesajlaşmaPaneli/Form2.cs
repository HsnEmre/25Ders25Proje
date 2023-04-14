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

namespace _11_MesajlaşmaPaneli
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string numara;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-972PD8E\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True");

        void GelenKutusu()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From TblMesajlar Where Alıcı=" + numara, baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = da1;
        }
        void GideKutusu()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From TblMesajlar Where Gonderen=" + numara, baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = da2;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GelenKutusu();
            LblNum.Text = numara;
            GideKutusu();
            baglanti.Open();
            //Ad Soyadı Çekme
            SqlCommand komut = new SqlCommand("Select Ad,Soyad From TblKisiler Where Numara=" + numara, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoy.Text = dr[0] + " " + dr[1];
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("İnsert into TblMesajlar(Gonderen,Alıcı,Baslik,İcerik) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            komut.Parameters.AddWithValue("@p2", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p3", textBox1.Text);
            komut.Parameters.AddWithValue("@p4", richTextBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Mesajınız iletildi");
            GideKutusu();
        }
    }
}
