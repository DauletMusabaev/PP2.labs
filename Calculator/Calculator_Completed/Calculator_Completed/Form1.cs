using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Completed
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operation = "";
        bool enter_value = false;
        bool op = false;
        public Form1()
        {
            InitializeComponent();
            this.Width = 251;
            textBox1.Width = 210;
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 251;
            textBox1.Width = 210;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 480;
            textBox1.Width = 439;
        }

        private void unitConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 704;
            textBox1.Width = 439;
        }

        private void multiplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Width = 704;
           textBox1.Width = 439;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (op)
            {
                textBox1.Text = "0";
                op = false;
            }
            if (textBox1.Text == "0" || (enter_value))
                textBox1.Text = "";
            enter_value = false;
            Button btn = (Button)sender;
            if (btn.Text == ",")
            {
                if (!textBox1.Text.Contains(","))
                   textBox1.Text = textBox1.Text + btn.Text;
            }
            else
                textBox1.Text = textBox1.Text + btn.Text;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = ""; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            if (textBox1.Text == "0")
                textBox1.Text = "";
        }

        private void Arithmetic_Operator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            result = Double.Parse(textBox1.Text);
            op = true;
            //textBox1.Text = "";
            label1.Text = result.ToString() + " " + operation;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            switch (operation)
            {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "×":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
                case "Mod":
                    textBox1.Text = (result % Double.Parse(textBox1.Text)).ToString();
                    break;
                case "Exp":
                    double i = Double.Parse(textBox1.Text);
                    double q;
                    q = result;
                    textBox1.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.PI).ToString();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);
            label1.Text = ("log" + "(" + textBox1.Text + ")");
            ilog = Math.Log10(ilog);
            textBox1.Text = ilog.ToString();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            double sq = Double.Parse(textBox1.Text);
            label1.Text = ("√" + "(" + textBox1.Text + ")");
            sq = Math.Sqrt(sq);
            textBox1.Text = sq.ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double sinh = Double.Parse(textBox1.Text);
            label1.Text = ("sinh" + "(" + textBox1.Text + ")");
            sinh = Math.Sinh(sinh * Math.PI / 180);
            textBox1.Text = sinh.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double sin = Double.Parse(textBox1.Text);
            label1.Text = ("sin" + "(" + textBox1.Text + ")");
            sin = Math.Sin(sin * Math.PI / 180);
            textBox1.Text = sin.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double cosh = Double.Parse(textBox1.Text);
            label1.Text = ("cosh" + "(" + textBox1.Text + ")");
            cosh = Math.Cosh(cosh * Math.PI / 180);
            textBox1.Text = cosh.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double cos = Double.Parse(textBox1.Text);
            label1.Text = ("cos" + "(" + textBox1.Text + ")");
            cos = Math.Cos(cos * Math.PI / 180);
            textBox1.Text = cos.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double tanh = Double.Parse(textBox1.Text);
            label1.Text = ("tanh" + "(" + textBox1.Text + ")");
            tanh = Math.Tanh(tanh * Math.PI / 180);
            textBox1.Text = tanh.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double tan = Double.Parse(textBox1.Text);
            label1.Text = ("tan" + "(" + textBox1.Text + ")");
            tan = Math.Tan(tan * Math.PI / 180);
            textBox1.Text = tan.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            label1.Text = ("Binary" + "(" + textBox1.Text + ")");
            textBox1.Text = System.Convert.ToString(a, 2);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            label1.Text = ("Hexadecimal" + "(" + textBox1.Text + ")");
            textBox1.Text = System.Convert.ToString(a, 16);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            label1.Text = ("Octal" + "(" + textBox1.Text + ")");
            textBox1.Text = System.Convert.ToString(a, 8);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            label1.Text = ("Decimal" + "(" + textBox1.Text + ")");
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Double a;
            label1.Text = (Convert.ToDouble(textBox1.Text) + "²" + "(" + textBox1.Text + ")");
            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = a.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Double a;
            label1.Text = (Convert.ToDouble(textBox1.Text) + "^3" + "(" + textBox1.Text + ")");
            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = a.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Double a;
            label1.Text = ("1/" + "(" + textBox1.Text + ")");
            a = 1.0 / Convert.ToDouble(textBox1.Text);
            textBox1.Text = a.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);
            label1.Text = ("ln" + "(" + textBox1.Text + ")");
            ilog = Math.Log(ilog);
            textBox1.Text = ilog.ToString();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Double a;
            label1.Text = ("100 %" + "(" + textBox1.Text + ")");
            a = Convert.ToDouble(textBox1.Text) / 100.0;
            textBox1.Text = a.ToString();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Double a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = (-1 * a) + "";
        }
    }
}
