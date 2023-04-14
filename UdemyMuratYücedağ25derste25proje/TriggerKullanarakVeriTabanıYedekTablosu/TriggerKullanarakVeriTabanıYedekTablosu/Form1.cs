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

namespace TriggerKullanarakVeriTabanıYedekTablosu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-972PD8E\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True");
        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TblKitaplar", bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
            sayac();
        }

        void sayac()
        {
            bag.Open();
            SqlCommand komut = new SqlCommand("select * from TblSayac",bag);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladet.Text = dr[0].ToString();
            }
            bag.Close();
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand kom = new SqlCommand("insert into TblKitaplar (ad,yazar,sayfa,yayınevi,Tur) values (@p1,@p2,@p3,@p4,@p4)", bag);
            kom.Parameters.AddWithValue("@p1", txtad.Text);
            kom.Parameters.AddWithValue("@p2", txtyazar.Text);
            kom.Parameters.AddWithValue("@p3", txtsayfa.Text);
            kom.Parameters.AddWithValue("@p4", txtyayınevi.Text);
            kom.Parameters.AddWithValue("@p5", txttur.Text);
            kom.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Kitap Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            sayac();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;

            txtıd.Text = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            txtyazar.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            txtsayfa.Text = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            txtyayınevi.Text = dataGridView1.Rows[sec].Cells[4].Value.ToString();
            txttur.Text = dataGridView1.Rows[sec].Cells[5].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand komut = new SqlCommand("Delete From TblKitaplar where Id=@p1", bag);
            komut.Parameters.AddWithValue("@p1", txtıd.Text);
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Kitap Sistemden Silindi");
            Listele();
            sayac();
        }
    }
}
