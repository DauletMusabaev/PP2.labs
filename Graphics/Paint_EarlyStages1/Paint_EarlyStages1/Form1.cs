using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_EarlyStages1
{
    public partial class Form1 : Form
    {
        Graphics bmpGraphics;
        Bitmap bmp;
        bool clicked;
        Point prev, cur;
        Pen penD, penE;
        enum Tool
        {
            PEN,
            FILL,
            RECTANGLE,
            ELLIPSE,
            TRIANGLE,
            ERASER
        };
        Tool tool = Tool.PEN;
        Queue<Point> q = new Queue<Point>();
        Color initColor;
        Color fillColor;

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            bmpGraphics = Graphics.FromImage(bmp);
            clicked = false;
            fillColor = colorDialog1.Color;
            bmpGraphics.Clear(Color.White);
            pictureBox2.BackColor = Color.Black;
            pictureBox3.BackColor = Color.White;

        }

        public void Check(int x, int y)
        {
            if (x < 0 || y < 0 || x >= pictureBox1.Width || y >= pictureBox1.Height)
                return; 
            if (bmp.GetPixel(x, y) == initColor)
            {
                bmp.SetPixel(x, y, fillColor);
                q.Enqueue(new Point(x, y));
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int x = Math.Min(cur.X, prev.X);
            int y = Math.Min(cur.Y, prev.Y);
            int w = Math.Abs(cur.X - prev.X);
            int h = Math.Abs(cur.Y - prev.Y);

            if (tool == Tool.RECTANGLE)
            {
                e.Graphics.DrawRectangle(penD, x, y, w, h);
            }
            if (tool == Tool.ELLIPSE)
                e.Graphics.DrawEllipse(penD, prev.X, prev.Y, cur.X - prev.X, cur.Y - prev.Y);
            if(tool == Tool.TRIANGLE)
            {
                Point[] pointsT = { new Point(w / 2 + x, y), new Point(x, Math.Max(prev.Y, cur.Y)), new Point(Math.Max(prev.X, cur.X), Math.Max(prev.Y, cur.Y)) };
                e.Graphics.DrawPolygon(penD, pointsT);
            }

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            clicked = true;
            prev = e.Location;
            fillColor = pictureBox2.BackColor;
            if (tool == Tool.FILL)
            {
                int x = e.X;
                int y = e.Y;
                initColor = bmp.GetPixel(x, y);
                q.Enqueue(new Point(x, y));
                bmp.SetPixel(x, y, fillColor);
                while (q.Count != 0)
                {
                    Point p = q.Dequeue();
                    Check(p.X - 1, p.Y);
                    Check(p.X + 1, p.Y);
                    Check(p.X, p.Y - 1);
                    Check(p.X, p.Y + 1);
                }
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            cur = e.Location;
            if (e.Button == MouseButtons.Left) penD = new Pen(pictureBox2.BackColor, trackBar1.Value);
            if (e.Button == MouseButtons.Right) penD = new Pen(pictureBox3.BackColor, trackBar1.Value);

            penE = new Pen(pictureBox3.BackColor, trackBar1.Value + 5);
            if (clicked)
            {
                if (tool == Tool.PEN)
                {
                    bmpGraphics.DrawLine(penD, prev.X, prev.Y, cur.X, cur.Y);
                    prev = cur;
                }
                if(tool == Tool.ERASER)
                {
                    bmpGraphics.DrawLine(penE, prev.X, prev.Y, cur.X, cur.Y);
                    prev = cur;
                }
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
            int x = Math.Min(e.X, prev.X);
            int y = Math.Min(e.Y, prev.Y);
            int w = Math.Abs(e.X - prev.X);
            int h = Math.Abs(e.Y - prev.Y);

            if (tool == Tool.RECTANGLE)
            {
                bmpGraphics.DrawRectangle(penD, x, y, w, h);
            }
            if (tool == Tool.ELLIPSE)
            {
                bmpGraphics.DrawEllipse(penD, prev.X, prev.Y, cur.X - prev.X, cur.Y - prev.Y);
            }
            if (tool == Tool.TRIANGLE)
            {
                Point[] pointsT = { new Point(w / 2 + x, y), new Point(x, Math.Max(prev.Y, cur.Y)), new Point(Math.Max(prev.X, cur.X), Math.Max(prev.Y, cur.Y)) };
                bmpGraphics.DrawPolygon(penD, pointsT);
            }
            pictureBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tool = Tool.PEN;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tool = Tool.RECTANGLE;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tool = Tool.ELLIPSE;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tool = Tool.FILL;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pictureBox2.BackColor = colorDialog1.Color;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pictureBox3.BackColor = colorDialog1.Color;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox2.BackColor = button9.BackColor;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox2.BackColor = button10.BackColor;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pictureBox2.BackColor = button11.BackColor;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pictureBox2.BackColor = button12.BackColor;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pictureBox2.BackColor = button16.BackColor;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pictureBox2.BackColor = button15.BackColor;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pictureBox2.BackColor = button14.BackColor;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pictureBox2.BackColor = button13.BackColor;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            pictureBox2.BackColor = button17.BackColor;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            pictureBox2.BackColor = button18.BackColor;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            bmp.Save(saveFileDialog1.FileName);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "(*.JPG)|*.JPG";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.OpenFile();
                bmp = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = bmp;
                bmpGraphics = Graphics.FromImage(bmp);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tool = Tool.TRIANGLE;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tool = Tool.ERASER;
        }

    }
}
