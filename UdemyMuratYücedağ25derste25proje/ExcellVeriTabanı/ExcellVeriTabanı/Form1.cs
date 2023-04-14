using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ExcellVeriTabanı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        OleDbConnection bag = new OleDbConnection(@"‪C:\Users\Hasan\OneDrive\Masaüstü\1.xlsx");
        void Listele()
        {
            bag.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from [sayfa1$]", bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bag.Close();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            bag.Open();
            OleDbCommand km = new OleDbCommand("İnsert into [sayfa1$] (saat,Ders) values (@p1,@p2)", bag);
            km.Parameters.AddWithValue("@p1", textBox1.Text);
            km.Parameters.AddWithValue("@p2", textBox2.Text);
            bag.Close();
        }
    }
}
