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

namespace _1_ÖğrenciSınavNotKAyıtSistemi
{
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-972PD8E\SQLEXPRESS;Initial Catalog=DbNotKayıt;Integrated Security=True");
        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNotKayıtDataSet.TblDers' table. You can move, or remove it, as needed.
            this.tblDersTableAdapter.Fill(this.dbNotKayıtDataSet.TblDers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TblDers (ogrnumara,ograd,ogrsoyad) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", mskNumara.Text);
            komut.Parameters.AddWithValue("@p2", txtad.Text);
            komut.Parameters.AddWithValue("@p3", txtsoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Sisteme Eklendi");
            // TODO: This line of code loads data into the 'dbNotKayıtDataSet.TblDers' table. You can move, or remove it, as needed.
            this.tblDersTableAdapter.Fill(this.dbNotKayıtDataSet.TblDers);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            mskNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txts1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txts2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txts3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            string durum;


            s1 = Convert.ToDouble(txts1.Text);
            s2 = Convert.ToDouble(txts2.Text);
            s3 = Convert.ToDouble(txts3.Text);

            ortalama = (s1 + s2 + s3) / 3;
            lblortalama.Text = ortalama.ToString();
            if (ortalama >= 50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update tblders set ogrsınav1=@p1,ogrsınav2=@p2,ogrsınav3=@p3,ortalama=@p4 ,durum=@p5 where ogrnumara = @p6 ", baglanti);

            komut.Parameters.AddWithValue("@p1", txts1.Text);
            komut.Parameters.AddWithValue("@p2", txts2.Text);
            komut.Parameters.AddWithValue("@p3", txts3.Text);
            komut.Parameters.AddWithValue("@p4", decimal.Parse(lblortalama.Text));
            komut.Parameters.AddWithValue("@p5", durum);
            komut.Parameters.AddWithValue("@p6", mskNumara.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("ogrenci notları güncellendi");

        }
    }
}
