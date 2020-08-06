using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0806
{
    public partial class Form1 : Form
    {
        int vx=-10, vy=-10,vt=120,vt2=10;
        string a = "ピンチ！＼(・ω・＼)";
        public Form1()
        {
            InitializeComponent();
            label1.Text = "(／・ω・)／SAN値";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "(・ω・)";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;


            if (label1.Left < 0)
            {
                vx = Math.Abs(vx); 
            }

            if(label1.Top < 0)
            {
                vy = Math.Abs(vy);
            }

            if (label1.Right > ClientSize.Height-50)
            {
                timer1.Interval = vt2;
            }
            else
            {
                timer1.Interval = vt;
            }

            if (label1.Top > ClientSize.Height-50)
            {
                timer1.Interval = vt2;
            }
            else
            {
                timer1.Interval = vt;
            }

            if (label1.Right > ClientSize.Height)
            {
                vx = -Math.Abs(vx);
            }

            if (label1.Top > ClientSize.Height)
            {
                vy = -Math.Abs(vy);
            }


            string s = label1.Text;
            label1.Text = a;
            a = s;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("幅" + ClientSize.Width);
            //MessageBox.Show("高さ" + ClientSize.Height);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
