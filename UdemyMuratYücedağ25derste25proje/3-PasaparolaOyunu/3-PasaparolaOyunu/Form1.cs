using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PasaparolaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                            button1.BackColor = Color.Green;
                            dogru += 1;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis += 1;
                            label6.Text = yanlis.ToString();
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "Bursa")
                        {
                            button2.BackColor = Color.Green;
                            dogru += 1;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis += 1;
                            label6.Text = yanlis.ToString();
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "Cuma")
                        {
                            button3.BackColor = Color.Green;
                            dogru += 1;
                            label4.Text = dogru.ToString();

                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis += 1;
                            label6.Text = yanlis.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text=="diyarbakır")
                        {
                            button4.BackColor = Color.Green;
                            dogru += 1;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis += 1;
                            label6.Text = yanlis.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text=="eski")
                        {
                            button5.BackColor = Color.Green;
                            dogru += 1;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis += 1;
                            label6.Text = yanlis.ToString();
                        }
                        break;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Cevapla";
            soruno += 1;
            this.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Ülkemizin güney bölgesindeki kıyı bölgesi ?";
                button1.BackColor = Color.Yellow;

            }

            if (soruno == 2)
            {
                richTextBox1.Text = "Yeşilliğiylew ünlü marmara ilimiz ?";
                button2.BackColor = Color.Yellow;

            }

            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların Kutsal günü ?";
                button3.BackColor = Color.Yellow;

            }

            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz?";
                button4.BackColor = Color.Yellow;

            }

            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı ?";
                button5.BackColor = Color.Yellow;

            }

            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali ?";
                button6.BackColor = Color.Yellow;

            }
        }
    }
}
