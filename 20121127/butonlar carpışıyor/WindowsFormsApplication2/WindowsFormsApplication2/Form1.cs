using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Controls.Add(btn1);
            this.Controls.Add(btn2);
            
            btn1.Text = "BMW";
            btn2.Text = "BMW2";
            timer1.Interval = 1;
            timer1.Start();
        }
        int b1x = 13;
        int b1y = 118;
        int b2x = 467;
        int b2y = 118;
        Button btn1 = new Button();
        Button btn2 = new Button();
       //g 103
       //u 117
       //i 105
       //e 101
        private void timer1_Tick(object sender, EventArgs e)
        {
            btn1.Location = new Point(b1x, b1y);
            btn2.Location = new Point(b2x, b2y);
            b1x += 2;
            b2x -= 2;
            if (b1x > b2x - 70)
            {
                timer1.Stop();
                timer2.Start();
                timer2.Interval = 1;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            btn1.Location = new Point(b1x, b1y);
            btn2.Location = new Point(b2x, b2y);
            b1x += 2;
            b1y -= 2;
            b2x -= 2;
            b2y += 2;

        }
       
        
        private void button1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                
            }

        }
       
    }
    
}
