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
        int vx=-10, vy=-10, vt=60, vt2=30;
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
            Point mp = MousePosition;
            mp = PointToClient(mp);
            label2.Left = mp.X ;
            label2.Top = mp.Y;
            label2.Text = "" + mp.X + "," + mp.Y;


            label1.Left += vx;
            label1.Top += vy;


            if (label1.Left < 0)
            {
                vx = Math.Abs(vx) * 11 / 10;
                timer1.Interval = vt;
            }
            if(label1.Top < 0)
            {
                vy = Math.Abs(vy) * 11 / 10;
                timer1.Interval = vt;
            }

            if (label1.Right > ClientSize.Height)
            {
                vx = -Math.Abs(vx) * 11 / 10;
                timer1.Interval = vt2;
            }

            if (label1.Top > ClientSize.Height)
            {
                vy = -Math.Abs(vy) * 11 / 10;
                timer1.Interval = vt2;
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
    }
}
