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

namespace _2_SeçimİstatistikveGrafikSistemi
{
    public partial class FrmGrafikler : Form
    {
        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-972PD8E\SQLEXPRESS;Initial Catalog=DbSecimProje;Integrated Security=True");
        public FrmGrafikler()
        {
            InitializeComponent();
        }

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("select ilcead from tblİlce", bgl);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            bgl.Close();

            //grafiğe Toplam 

            bgl.Open();
            SqlCommand komut2 = new SqlCommand("select sum(Aparti),sum(bparti),sum(cparti),sum(dparti),sum(eparti) from Tblİlce", bgl);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A Parti", dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("B parti", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("C parti", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("D parti", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("E parti", dr2[4]);

            }
            bgl.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("Select * From Tblİlce where ilcead=@p1",bgl);
            komut.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                progressBar1.Value = int.Parse(dr[2].ToString());
                progressBar2.Value = int.Parse(dr[3].ToString());
                progressBar3.Value = int.Parse(dr[4].ToString());
                progressBar4.Value = int.Parse(dr[5].ToString());
                progressBar5.Value = int.Parse(dr[6].ToString());

                lbla.Text = dr[2].ToString();
                lblb.Text = dr[3].ToString();
                lvlc.Text = dr[4].ToString();
                lbld.Text = dr[5].ToString();
                lble.Text = dr[6].ToString();

            }
            bgl.Close();
        }
    }
}
