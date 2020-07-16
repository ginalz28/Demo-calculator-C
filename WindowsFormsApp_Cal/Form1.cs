using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Cal
{
    public partial class Form1 : Form
    {
        double value = 0;
        String operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();
            operation_pressed = false;
            Button b = (Button)sender;
            if(b.Text == ".")
            {
                if (!result.Text.Contains("."))
                    result.Text = result.Text + b.Text;
            }
            else
                result.Text = result.Text + b.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void tinhtoan_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch(operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
           
        }
        private void button10_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        }
    }
}
