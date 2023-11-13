using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SiniflarDevamEdiyor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ANONİM SINIF:
            //AŞAĞIDAKİ GİBİ TANIMLANIR,İÇİNE YALNIZCA ALAN
            //(YANİ DEĞİŞKEN) ALABİLİR VE HEPSİ PUBLİC OLUR.
            //METOT BARINDIRAMAZ.DEĞİŞKEN TÜRLERİ VERİLEN
            //DEĞERLERE GÖRE BELİRLENİR.
            //DEĞİŞKENLERE SONRADAN DEĞER ATANAMAZ.
            var Bisiklet = new { VitesSayisi = 12, TekerSayisi = 2, Marka = "bianchi" };
            MessageBox.Show(Bisiklet.Marka);


            MessageBox.Show(Bisiklet.TekerSayisi.ToString());
            MessageBox.Show(Bisiklet.VitesSayisi.ToString());
            //timer1.Interval = 1;
            //timer1.Start();
                       
        }
        int bx = 10;
        int by = 10;
        int b2x = 684;
        int b2y = 10;

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10000; i++)
            {
                button1.Location = new Point(bx, by);
                button2.Location = new Point(b2x, b2y);
                bx += 2;
                b2x -= 2;
                for (int k = 0; k < 10000000; k++)
                {
                    if (bx > b2x - 70)
                    {
                        break;
                    }
                }

            }
            for (int i = 0; i < 10000; i++)
            {
                button1.Location = new Point(bx, by);
                button2.Location = new Point(b2x, b2y);
                by -= 2;
                b2y += 2;
                for (int k = 0; k < 10000000; k++)
                {
                    if (by > b2y - 70)
                    {
                        break;
                    }

                }
                
            }
        }
        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    button1.Location = new Point(bx,by);
        //    button2.Location = new Point(b2x,b2y);
        //    bx += 2;
        //    b2x -= 2;
        //    if (bx==b2x-20)
        //    {
                
        //        timer1.Stop();
                               
        //    }
        //}

        //private void timer2_Tick(object sender, EventArgs e)
        //{
        //    button1.Location = new Point(bx, by);
        //    button2.Location = new Point(b2x, b2y);
        //    by += 2;
        //    b2y -= 2;
        //    if (by == b2y)
        //    {
        //        timer1.Stop();
                
        //    }
        //}

     }
}
