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

namespace PetrolAkaryakıtSis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-972PD8E\SQLEXPRESS;Initial Catalog=TestBenzin;Integrated Security=True");


        void Listele()
        {
            bag.Open();
            SqlCommand kom = new SqlCommand("Select * from TblBenzin where PetrolTur='Kurşunsuz95'", bag);
            SqlDataReader dr = kom.ExecuteReader();
            while (dr.Read())
            {
                lbl95.Text = dr[3].ToString();
                progressBar1.Value = int.Parse(dr[4].ToString());
                lbl95l.Text = dr[4].ToString();
            }
            bag.Close();

            bag.Open();
            SqlCommand kom2 = new SqlCommand("Select * from TblBenzin where PetrolTur='Kurşunsuz97'", bag);
            SqlDataReader dr2 = kom2.ExecuteReader();
            while (dr2.Read())
            {
                lbl97.Text = dr2[3].ToString();
                progressBar2.Value = int.Parse(dr2[4].ToString());
                lbl97l.Text = dr2[4].ToString();
            }
            bag.Close();

            bag.Open();
            SqlCommand kom3 = new SqlCommand("Select * from TblBenzin where PetrolTur='EuroDizel10'", bag);
            SqlDataReader dr3 = kom3.ExecuteReader();
            while (dr3.Read())
            {
                lbl10.Text = dr3[3].ToString();
                progressBar3.Value = int.Parse(dr3[4].ToString());
                lbl10l.Text = dr3[4].ToString();
            }
            bag.Close();

            bag.Open();
            SqlCommand kom4 = new SqlCommand("Select * from TblBenzin where PetrolTur='YeniProDizel10'", bag);
            SqlDataReader dr4 = kom4.ExecuteReader();
            while (dr4.Read())
            {
                lblpro.Text = dr4[3].ToString();
                progressBar4.Value = int.Parse(dr4[4].ToString());
                lblpl.Text = dr4[4].ToString();
            }
            bag.Close();


            bag.Open();
            SqlCommand kom5 = new SqlCommand("Select * from TblBenzin where PetrolTur='Gaz'", bag);
            SqlDataReader dr5 = kom5.ExecuteReader();
            while (dr5.Read())
            {
                lblgaz.Text = dr5[3].ToString();
                progressBar5.Value = int.Parse(dr5[4].ToString());
                lblgazl.Text = dr5[4].ToString();
            }
            bag.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void nm95fiy_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz95, litre, tutar;
            kursunsuz95 = Convert.ToDouble(lbl95.Text);
            litre = Convert.ToInt16(nm95fiy.Value);
            tutar = kursunsuz95 * litre;
            txtkursunsuz95tut.Text = tutar.ToString();
        }

        private void nm97fiy_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz97, litre, tutar;
            kursunsuz97 = Convert.ToDouble(lbl97.Text);
            litre = Convert.ToInt16(nm97fiy.Value);
            tutar = kursunsuz97 * litre;
            txtkursunsuz97fiy.Text = tutar.ToString();
        }

        private void nmdiz10fiy_ValueChanged(object sender, EventArgs e)
        {
            double dizel10, litre, tutar;
            dizel10 = Convert.ToDouble(lbl10.Text);
            litre = Convert.ToInt16(nmdiz10fiy.Value);
            tutar = dizel10 * litre;
            txteurodiz10tut.Text = tutar.ToString();
        }

        private void nmprodizfiy_ValueChanged(object sender, EventArgs e)
        {
            double prodizel, litre, tutar;
            prodizel = Convert.ToDouble(lblpro.Text);
            litre = Convert.ToInt16(nmprodizfiy.Value);
            tutar = prodizel * litre;
            txtyenprodiztut.Text = tutar.ToString();
        }

        private void nmgazfiy_ValueChanged(object sender, EventArgs e)
        {
            double gaz, litre, tutar;
            gaz = Convert.ToDouble(lblgaz.Text);
            litre = Convert.ToInt16(nmgazfiy.Value);
            tutar = gaz * litre;
            txtgaztut.Text = tutar.ToString();
        }

        private void btndepodoldur_Click(object sender, EventArgs e)
        {
            if (nm95fiy.Value != 0)
            {
                bag.Open();
                SqlCommand kom = new SqlCommand("insert into tblhareket (plaka,BenzinTürü,litre,Fiyat) values (@p1,@p2,@p3,@p4)", bag);
                kom.Parameters.AddWithValue("@p1", txtplaka.Text);
                kom.Parameters.AddWithValue("@p2", "Kurşunsuz95");
                kom.Parameters.AddWithValue("@p3", nm95fiy.Text);
                kom.Parameters.AddWithValue("@p4", txtkursunsuz95tut.Text);
                kom.ExecuteNonQuery();
                bag.Close();
                MessageBox.Show("Satış Yapıldı");

            }
        }
    }
}
