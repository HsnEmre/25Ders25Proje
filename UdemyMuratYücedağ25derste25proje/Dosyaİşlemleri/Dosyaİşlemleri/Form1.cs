using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dosyaİşlemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string resim;

        private void btnresim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            resim = openFileDialog1.FileName;

        }

        Color renk;
        private void btnrenk_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            renk = colorDialog1.Color;
        }


        Bitmap bmp;
        private void btnyazdır_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(resim);
            Graphics gr = Graphics.FromImage(bmp);
            gr.DrawString(txtmetin.Text, new Font("Segoe UI", Convert.ToInt16(txtboyut), FontStyle.Bold), new SolidBrush(renk), 20, 30);
            pictureBox1.Image = bmp;
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Resim.jpg";
            saveFileDialog1.ShowDialog();
            bmp.Save(saveFileDialog1.FileName);
        }
    }
}
