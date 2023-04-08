using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
   
                     



        }
      
         
        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        int[] cevaplar = {5,6,54,36,10};
        int soru = 0,dogru=0,yanlıs=0,kalanzaman=0,dakika=0;
        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();


            soru++;

            if (soru == 1)
            {
                richTextBox1.Text = "3+2";
                button1.Text = "5";
                button2.Text = "8";
                button3.Text = "8";
                button4.Text = "9";
                progressBar1.Value += 30;
               
                
            }
            else if (soru == 2)
            {
                richTextBox1.Text = "4+2";
                button1.Text = "6";
                button2.Text = "5";
                button3.Text = "8";
                button4.Text = "7";
                progressBar1.Value += 30;

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
            else if (soru == 3)
            {
                richTextBox1.Text = "6*9";
                button1.Text = "54";
                button2.Text = "72";
                button3.Text = "53";
                button4.Text = "52";
              //  progressBar1.Value += 30;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
            else if (soru == 4)
            {
                richTextBox1.Text = "4*9";
                button1.Text = "35";
                button2.Text = "32";
                button3.Text = "36";
                button4.Text = "30";
                progressBar1.Value += 30;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
            else if (soru == 5)
            {
                richTextBox1.Text = "5*2";
                button1.Text = "10";
                button2.Text = "12";
                button3.Text = "5";
                button4.Text = "50";
                progressBar1.Value += 10;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cevaplar[0].ToString() == button1.Text)
            {
                dogru++;
                MessageBox.Show("Tebrikler Doğru");
                label2.Text = dogru.ToString();

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else if (cevaplar[1].ToString() == button1.Text)
            {
                dogru++;
                MessageBox.Show("Tebrikler Doğru");
                label2.Text = dogru.ToString();

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else if (cevaplar[2].ToString() == button1.Text)
            {
                dogru++;
                MessageBox.Show("Tebrikler Doğru");
                label2.Text = dogru.ToString();

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else if (cevaplar[3].ToString() == button3.Text)
            {
                yanlıs++;
                MessageBox.Show("Yanlıs");
                label3.Text = yanlıs.ToString();

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else if (cevaplar[4].ToString() == button1.Text)
            {
                dogru++;
                MessageBox.Show("Tebrikler Doğru");
                label2.Text = dogru.ToString();

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (cevaplar[0].ToString() == button1.Text)
            {
                yanlıs++;

                label3.Text = yanlıs.ToString();

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else if (cevaplar[1].ToString() == button1.Text)
            {
                yanlıs++;
                MessageBox.Show("Yanlış");
                label3.Text = yanlıs.ToString();

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else if (cevaplar[2].ToString() == button1.Text)
            {
                yanlıs++;
                MessageBox.Show("Yanlış");
                label3.Text = yanlıs.ToString();

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else if (cevaplar[3].ToString() == button3.Text)
            {
                yanlıs++;
                MessageBox.Show("Yanlıs");
                label3.Text = yanlıs.ToString();

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else if (cevaplar[4].ToString() == button4.Text)
            {
                yanlıs++;
                MessageBox.Show("Yanlıs");
                label3.Text = yanlıs.ToString();

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (cevaplar[0].ToString() == button1.Text)
            {
                yanlıs++;

                label3.Text = yanlıs.ToString();

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else if (cevaplar[1].ToString() == button1.Text)
            {
                yanlıs++;
                MessageBox.Show("Yanlış");
                label3.Text = yanlıs.ToString();

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else if (cevaplar[2].ToString() == button1.Text)
            {
                yanlıs++;
                MessageBox.Show("Yanlış");
                label3.Text = yanlıs.ToString();

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else if (cevaplar[3].ToString() == button3.Text)
            {
                dogru++;
                MessageBox.Show("Doğru");
                label2.Text = dogru.ToString();

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else if (cevaplar[4].ToString() == button4.Text)
            {
                yanlıs++;
                MessageBox.Show("Yanlıs");
                label3.Text = yanlıs.ToString();

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (cevaplar[0].ToString() == button1.Text)
            {
                yanlıs++;

                label3.Text = yanlıs.ToString();

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else if (cevaplar[1].ToString() == button1.Text)
            {
                yanlıs++;
                MessageBox.Show("Yanlış");
                label3.Text = yanlıs.ToString();

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else if (cevaplar[2].ToString() == button1.Text)
            {
                yanlıs++;
                MessageBox.Show("Yanlış");
                label3.Text = yanlıs.ToString();

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else if (cevaplar[3].ToString() == button3.Text)
            {
                yanlıs++;
                MessageBox.Show("Yanlıs");
                label3.Text = yanlıs.ToString();

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else if (cevaplar[4].ToString() == button4.Text)
            {
                yanlıs++;
                MessageBox.Show("Yanlıs");
                label3.Text = yanlıs.ToString();

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }



            
           


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            kalanzaman++;
            label7.Text = kalanzaman.ToString();

            if (kalanzaman == 60)
            {
                kalanzaman = 0;
                label7.Text = kalanzaman.ToString();
                dakika++;
                label6.Text = dakika.ToString();

            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            label6.Text = dakika.ToString();

        }

  


       



    }
}
