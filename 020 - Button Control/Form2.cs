using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _020___Button_Control
{
    public partial class Form2 : Form
    {
        double number1, number2;
        string op = "";
        bool clearLabel = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void Digit_Click(object sender, EventArgs e)
        {
            // Conditions...
            if(clearLabel==true)
            {
                label1.Text = "";
                clearLabel = false;
            }
            //  Buttons in one variable
            string d = ((Button)sender).Text;
            if (label1.Text.Length <= 10)
            {
                if (!(label1.Text == "" && d == "0"))
                {
                    // Assigning Buttons Text To Label
                    label1.Text += ((Button)sender).Text;
                }
            }
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            // Changing Sign Of Current Number
            label1.Text = (-Convert.ToDouble(label1.Text)).ToString();
        }

        private void btnDecimalPoint_Click(object sender, EventArgs e)
        {
            //  Checking Whether the Dot is present before

            if (!label1.Text.Contains("."))
                label1.Text += ".";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            number2 = Convert.ToDouble(label1.Text);
            // Making result variable for displaying results
            double result = 0;
            //  Using switch statement
            switch(op)
            {
                case "+": result = number1 + number2; break;
                case "-": result = number1 - number2; break;
                case "*": result = number1 * number2; break;
                case "/": result = number1 / number2; break;
            }
            label1.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clearing present Text in Label1
            label1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
          //  label1.Text = (-Convert.ToDouble(label1.Text)).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Clearing Text in label after all
            number1 = Convert.ToDouble(label1.Text);
            op = ((Button)sender).Text;
            clearLabel = true;
        }
    }
}
