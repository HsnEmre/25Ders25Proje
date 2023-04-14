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
    public partial class FrmOyGiris : Form
    {

        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-972PD8E\SQLEXPRESS;Initial Catalog=DbSecimProje;Integrated Security=True");
        public FrmOyGiris()
        {
            InitializeComponent();
        }

        private void BtnGraf_Click(object sender, EventArgs e)
        {
            FrmGrafikler f = new FrmGrafikler();
            f.Show();
            this.Hide();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("insert into Tblİlce (ilcead,aparti,bparti,cparti,dparti,eparti) values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl);
            komut.Parameters.AddWithValue("@p1", TxtIlceAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtA.Text);
            komut.Parameters.AddWithValue("@p3", TxtB.Text);
            komut.Parameters.AddWithValue("@p4", TxtC.Text);
            komut.Parameters.AddWithValue("@p5", TxtD.Text);
            komut.Parameters.AddWithValue("@p6", TxtE.Text);
            komut.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Oy Girişi Gerçekleştirildi");

        }

       
    }
}
