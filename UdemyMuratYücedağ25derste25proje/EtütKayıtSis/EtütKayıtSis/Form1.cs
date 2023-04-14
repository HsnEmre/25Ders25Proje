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

namespace EtütKayıtSis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-972PD8E\SQLEXPRESS;Initial Catalog=EtutTest;Integrated Security=True");

        void DersListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TblDersler", bag);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmDers.ValueMember = "DersId";//arkada planda çalışan değeri hafızada tutar ıd
            cmDers.DisplayMember = "DersAd";//ön planda çalışır
            cmDers.DataSource = dt;
        }
        void EtutListesi()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("execute Etut",bag);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DersListesi();
            EtutListesi();
        }
        
        private void cmDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SqlDataAdapter ogrtGetir = new SqlDataAdapter("select OgrtID,(Ad+''+Soyad)as AdSoyad from TblOgretmen where BransID =" + cmDers.SelectedValue, bag);
            DataTable dt2 = new DataTable();
            ogrtGetir.Fill(dt2);
            cmbOgretmen.ValueMember="OgrtId";
            cmbOgretmen.DisplayMember = "AdSoyad";
            cmbOgretmen.DataSource = dt2;

        }

        private void btnEtut_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand kom = new SqlCommand("insert into TblEtut (DersId,OgretmenId,Tarıh,Saat) values (@p1,@p2,@p3,@p4)", bag);
            kom.Parameters.AddWithValue("@p1",cmDers.SelectedValue);
            kom.Parameters.AddWithValue("@p2", cmbOgretmen.SelectedValue);
            kom.Parameters.AddWithValue("@p3", mskTarih.Text);
            kom.Parameters.AddWithValue("@p4", mskSaat.Text);
            kom.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Etüt Oluşturuldu");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtıd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void EtütVer_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand komut = new SqlCommand("Update TblEtut Set OgrencıId=@p1,durum=@p2 where ıd=@p3", bag);
            komut.Parameters.AddWithValue("@p1", tctogrnci.Text);
            komut.Parameters.AddWithValue("@p2", "True");
            komut.Parameters.AddWithValue("@p3", txtıd.Text);
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Etüt Öğrenciye Verildi");
        }
    }
}
