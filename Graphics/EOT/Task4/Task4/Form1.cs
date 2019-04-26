using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.Black);
            g.Clear(Color.White);
            g.DrawString("Hello World!", new Font(FontFamily.GenericSansSerif, trackBar1.Value), brush, 100, 100);

        }
    }
}
