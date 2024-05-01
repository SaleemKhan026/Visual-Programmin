using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buttons_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Digit_Click(object sender, EventArgs e)
        {
            //Enters one number only 
            // label1.Text = ((Button)sender).Text;
            //Enters each number
            if (!label1.Text.Contains("0")) { 
                label1.Text += ((Button)sender).Text;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!label1.Text.Contains("."))
                label1.Text += ".";
        }

        private void btnPlusMinus(object sender, EventArgs e)
        {
            //label1.Text = -Convert.ToDouble(label1.Text).ToString();
        }

        private void Operators_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(label1.Text);
            label1.Text = "";
        }
    }
}
