using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example3
{
    public partial class Form1 : Form
    {
        Graphics g;
        GraphicsPath gp = new GraphicsPath();

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gp.AddLine(10, 10, 100, 100);
            gp.AddEllipse(20, 30, 50, 50);
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawPath(new Pen(Color.Black, 3), gp);
        }
    }
}
