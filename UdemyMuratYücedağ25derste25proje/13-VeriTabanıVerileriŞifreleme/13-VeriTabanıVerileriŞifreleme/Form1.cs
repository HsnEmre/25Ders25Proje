using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//sql kullanmak için gerekli kütüphane

namespace _13_VeriTabanıVerileriŞifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-972PD8E\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True");
        //sql bağlantısını sağlıyorum 


        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Ad,Soyad,Mail,Sifre,Hesapno from tblVeriler", bag);
            DataSet ds = new DataSet();
            da.Fill(ds);
            foreach(DataRow row in ds.Tables[0].Rows)
            {
                row["Ad"] = Coz(row["Ad"] as string);
                row["Soyad"] = Coz(row["Soyad"] as string);
                row["Sifre"] = Coz(row["Sifre"] as string);
                row["Mail"] = Coz(row["Mail"] as string);
                row["Hesapno"] = Coz(row["Hesapno"] as string);

            }
            dataGridView1.DataSource = ds.Tables[0];

        }

        private object Coz(string V1)
        {
            byte[] cozumDizi = Convert.FromBase64String(V1);
            string adverisi = ASCIIEncoding.ASCII.GetString(cozumDizi);
            return adverisi;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string ad = txtad.Text;//metin i aldım 
            byte[] AdDizi = ASCIIEncoding.ASCII.GetBytes(ad);//byte tipinde dizi oluşturuyorum adı veridizisi
            //asci olarak kodla asciyi byte olarak getir bana
            string AdSifre = Convert.ToBase64String(AdDizi);
            //string değişkene veri dizisine attığımız değeri tobase formatında şifreleyip değişkene postaladım

            string soyad = txtsoyad.Text;
            byte[] SoyadDizi = ASCIIEncoding.ASCII.GetBytes(soyad);
            string SoyadSifre = Convert.ToBase64String(SoyadDizi);

            string mail = txtmail.Text;
            byte[] MailDizi = ASCIIEncoding.ASCII.GetBytes(mail);
            string MailSifre = Convert.ToBase64String(MailDizi);

            string sifre = txtsifre.Text;
            byte[] SifreDizi = ASCIIEncoding.ASCII.GetBytes(sifre);
            string SifreliSifre = Convert.ToBase64String(SifreDizi);

            string hesapNo = txthesapno.Text;
            byte[] SifreHesap = ASCIIEncoding.ASCII.GetBytes(hesapNo);
            string SifreliHesap = Convert.ToBase64String(SifreHesap);

            bag.Open();
            SqlCommand komut = new SqlCommand("insert into TblVeriler (Ad,Soyad,Mail,Sifre,Hesapno) values (@p1,@p2,@p3,@p4,@p5)", bag);
            komut.Parameters.AddWithValue("@p1", AdSifre);
            komut.Parameters.AddWithValue("@p2", SoyadSifre);
            komut.Parameters.AddWithValue("@p3", MailSifre);
            komut.Parameters.AddWithValue("@p4", SifreliSifre);
            komut.Parameters.AddWithValue("@p5", SifreliHesap);

            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Veriler Eklendi");
            

        }
            
          


        private void button2_Click(object sender, EventArgs e)
        {
            string AdCözüm = txtad.Text;
            byte[] AdCözümDizi = Convert.FromBase64String(AdCözüm);
            string AdVerisi = ASCIIEncoding.ASCII.GetString(AdCözümDizi);
            label6.Text = AdVerisi;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        
    }
}
