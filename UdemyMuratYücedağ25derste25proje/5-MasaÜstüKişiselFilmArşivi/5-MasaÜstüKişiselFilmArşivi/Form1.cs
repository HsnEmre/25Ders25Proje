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

namespace _5_MasaÜstüKişiselFilmArşivi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("insert into TBLFilmler(Ad,Kategori,LINK) values (@p1,@p2,@p3)", bgl);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtkategori.Text);
            komut.Parameters.AddWithValue("@p3", txtlnk.Text);

            komut.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Film Listemize Eklendi", "Bilg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Filmler();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-972PD8E\SQLEXPRESS;Initial Catalog=FilmArsivim;Integrated Security=True");
        void Filmler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Ad,LINK from TblFilmler", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Filmler();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            string link = dataGridView1.SelectedRows[secilen].Cells[3].Value.ToString();
            webBrowser1.Navigate(link);
        }
    }
}
