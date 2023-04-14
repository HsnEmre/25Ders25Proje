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
    public partial class FrmOgrenciDetay : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-972PD8E\SQLEXPRESS;Initial Catalog=DbNotKayıt;Integrated Security=True");
        public FrmOgrenciDetay()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public string numara;
        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
            lblnumara.Text = numara;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TblDers Where OGRNUMARA=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lbladsoyad.Text = oku[2].ToString() + " " + oku[3].ToString();
                lblsınav1.Text = oku[4].ToString();
                lblsınav2.Text = oku[5].ToString();
                lblsınav3.Text = oku[6].ToString();
                lblortalama.Text = oku[7].ToString();
                lbldurum.Text = oku[8].ToString();
            }
        }
    }
}
