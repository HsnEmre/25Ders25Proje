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

namespace ÜrünMaliyetSis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-972PD8E\SQLEXPRESS;Initial Catalog=TestMaliyet;Integrated Security=True");

        void malzemeListe()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tblmalzemeler", bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void ürünListesi()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("select * from tblurunler", bag);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }
        void kasa()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("select * from tblkasa", bag);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }
        void Urunler()
        {
            bag.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblurunler", bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbürün.ValueMember = "UrunId";
            cmbürün.DisplayMember = "Ad";
            cmbürün.DataSource = dt;
            bag.Close();
        }
        void malzemeler()
        {
            bag.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblmalzemeler", bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbmalzeme.ValueMember = "MalzemeId";
            cmbmalzeme.DisplayMember = "Ad";
            cmbmalzeme.DataSource = dt;
            bag.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            malzemeListe();
            Urunler();
            malzemeler();
        }

        private void btnürünlistesi_Click(object sender, EventArgs e)
        {
            ürünListesi();
        }

        private void btnmalzemelistesi_Click(object sender, EventArgs e)
        {
            malzemeListe();
        }

        private void btnkasa_Click(object sender, EventArgs e)
        {
            kasa();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnmlzemeekle_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand kom = new SqlCommand("insert into tblmalzemeler(ad,stok,fiyat,notlar) values (@p1,@p2,@p3,@p4)", bag);
            kom.Parameters.AddWithValue("@p1", txtstokad.Text);
            kom.Parameters.AddWithValue("@p2", decimal.Parse(txtstok.Text));
            kom.Parameters.AddWithValue("@p3", decimal.Parse(txtstokfiy.Text));
            kom.Parameters.AddWithValue("@p4", txtstoknot.Text);
            kom.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Malzeme Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            malzemeListe();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand kom = new SqlCommand("insert into tblUrunler(ad) values (@p1)", bag);
            kom.Parameters.AddWithValue("@p1", txtgirisad.Text);
            kom.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("ürün sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ürünListesi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand kom = new SqlCommand("insert into tblfırın (UrunID,MalzemeId,Miktar,Maliyet) values(@p1,@p2,@p3,@p4)", bag);
            kom.Parameters.AddWithValue("@p1", cmbürün.SelectedValue);
            kom.Parameters.AddWithValue("@p2", cmbmalzeme.SelectedValue);
            kom.Parameters.AddWithValue("@p3", decimal.Parse(txtmik.Text));
            kom.Parameters.AddWithValue("@p4", decimal.Parse(txtmaliyet.Text));
            kom.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("malzeme eklendii", "Bilgi", MessageBoxButtons.OK);

        }

        private void txtmik_TextChanged(object sender, EventArgs e)
        {
            double maliyet;

            if (txtmik.Text=="")
            {
                txtmik.Text = "0";
            }

            bag.Open();
            SqlCommand kom = new SqlCommand("select * from tblmalzemeler where malzemeıd=@p1",bag);
            kom.Parameters.AddWithValue("@p1", cmbmalzeme.SelectedValue);
            SqlDataReader dr = kom.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(cmbmalzeme.Text + "-" + cmbmalzeme.Text);
            }
        }
    }
}
