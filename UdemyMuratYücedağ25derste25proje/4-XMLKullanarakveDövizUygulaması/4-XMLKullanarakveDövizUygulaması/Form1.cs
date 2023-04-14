using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace _4_XMLKullanarakveDövizUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string bugün = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugün);


            string dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lbldolaral.Text = dolaralis;

            string dolarsat = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lbldolarsat.Text = dolarsat;

            string euroalis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lbleual.Text = euroalis;

            string eursat = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lbleusat.Text = eursat;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbldolaral.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbldolarsat.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbleual.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbleusat.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar;
            kur = Convert.ToDouble(txtkur.Text);
            miktar = Convert.ToDouble(textBox2.Text);
            tutar = kur * miktar;
            textBox3.Text = tutar.ToString();
        }

        private void txtkur_TextChanged(object sender, EventArgs e)
        {
            txtkur.Text = txtkur.Text.Replace(".",",");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double kur = Convert.ToDouble(txtkur.Text);
            int miktar = Convert.ToInt32(textBox2.Text);
            int tutar = miktar / Convert.ToInt32( kur);
            textBox3.Text = tutar.ToString();
        }
    }
}
