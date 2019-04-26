using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_EarlyStages
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen;
        bool clicked;
        float prevX, prevY;

        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            pen = new Pen(Color.Aquamarine, 4);
            clicked = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            clicked = true;
            prevX = e.X;
            prevY = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            float x = Math.Min(e.X, prevX);
            float y = Math.Min(e.Y, prevY);
            float w = Math.Abs(e.X - prevX);
            float h = Math.Abs(e.Y - prevY);

            if (clicked)
            {
                g.Clear(Color.Yellow);
                g.DrawRectangle(pen, x, y, w, h);
            }
            
        }
    }
}
