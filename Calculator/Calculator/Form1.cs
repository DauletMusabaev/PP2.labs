using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button_Click(object sender, EventArgs e)
        {

            if (textBox_Result.Text == "0" || isOperationPerformed)
                textBox_Result.Clear();

            isOperationPerformed = false;
            Button btn = (Button) sender;
            if(btn.Text == ",")
            {
                if(!textBox_Result.Text.Contains(","))
                    textBox_Result.Text = textBox_Result.Text + btn.Text;
            }
            else 
            textBox_Result.Text = textBox_Result.Text + btn.Text;
            
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (resultValue != 0)
            {
                button16.PerformClick();
                operationPerformed = btn.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
            
                operationPerformed = btn.Text;
                resultValue = Double.Parse(textBox_Result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "x^2":
                    textBox_Result.Text = (Math.Pow(resultValue, 2)).ToString();
                    break;
                case "sqrt":
                    textBox_Result.Text = (Math.Sqrt(resultValue)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textBox_Result.Text);
            labelCurrentOperation.Text = "";
        }
    }
}
