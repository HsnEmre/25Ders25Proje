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
namespace _9_MailTelefon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-972PD8E\SQLEXPRESS;Initial Catalog=Rehber;Integrated Security=True");

        void Listele()
        {
            DataTable dt = new DataTable();//verilerin sanal hafızada tutulması
            SqlDataAdapter da = new SqlDataAdapter("Select * from Kisiler", baglanti);//gerekli sql sorgum
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void temizle()
        {
            txtad.Clear();
            txtsoyad.Clear();
            txtsoyad.Clear();
            mskmail.Clear();
            msktel.Clear();
            txtıd.Clear();
            txtad.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Kisiler (Ad,Soyad,Telefon,Mail) values (@p1,@p2,@p3,@p4)",baglanti);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktel.Text);
            komut.Parameters.AddWithValue("@p4", mskmail.Text);
            komut.ExecuteNonQuery();//sorguyu çalıştır
            baglanti.Close();
            MessageBox.Show("Kişi Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            temizle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtıd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            msktel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskmail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult r1= MessageBox.Show("Kişiyi Silmek istedğinizden eminmisiniz ?","Bilgi",MessageBoxButtons.YesNo);
            if (r1==DialogResult.Yes)
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From Kisiler Where Id =" + txtıd.Text, baglanti);
                komut.ExecuteNonQuery();
                
            }
            baglanti.Close();
            Listele();
            temizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Kisişer Set Ad=@p1,Soyad@p2,Telefon=@p3,Mail=@p4 where Id=@p5", baglanti);
            komut.Parameters.AddWithValue("@p1", txtıd.Text);
            komut.Parameters.AddWithValue("@p2", txtad.Text);
            komut.Parameters.AddWithValue("@p3", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p4", msktel.Text);
            komut.Parameters.AddWithValue("@p5", mskmail.Text);
            baglanti.Close();
            Listele();
            temizle();
        }
    }
}
