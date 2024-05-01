using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Shop_Computers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox1.BackColor = Color.Yellow;
            groupBox2.BackColor = Color.BurlyWood;
            groupBox4.BackColor = Color.BurlyWood;
            groupBox3.BackColor = Color.BurlyWood;
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox9_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
            groupBox3.BackColor = Color.Yellow;
            groupBox1.BackColor = Color.Cyan;
            groupBox2.BackColor = Color.Cyan;
            groupBox4.BackColor = Color.Cyan;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox3.Checked = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox4.Checked = true;
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            checkBox14.Checked = true;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            checkBox12.Checked = true;
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            checkBox13.Checked = true;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            checkBox11.Checked = true;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            checkBox8.Checked = true;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            checkBox6.Checked = true;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            checkBox7.Checked = true;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox5.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            groupBox2.BackColor = Color.Yellow;
            groupBox1.BackColor = Color.Brown;
            groupBox3.BackColor = Color.Brown;
            groupBox4.BackColor = Color.Brown;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox4.Enabled = true;
            groupBox4.BackColor = Color.Yellow;
            groupBox3.BackColor = Color.Bisque;
            groupBox1.BackColor = Color.Bisque;
            groupBox2.BackColor = Color.Bisque;
        }
    }
}
