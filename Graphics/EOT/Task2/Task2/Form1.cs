using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        Graphics g;
        Point p;
        int r = 30;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
        string[] colors = { "red", "blue", "purple", "green", "cyan", "magenta" };

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            r = 5;
            p = e.Location;
            timer1.Start();
            g.Clear(Color.White);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            r = r + 5;
            int index = new Random().Next(0, colors.Length);
            g.DrawEllipse(new Pen(Color.FromName(colors[index])), p.X, p.Y, r * 2, r * 2);
        }

    }
}
