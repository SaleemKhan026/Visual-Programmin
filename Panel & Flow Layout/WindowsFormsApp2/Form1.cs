using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            flowLayoutPanel4.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel3.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel5.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
;        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.TopLevel = false;
            panel2.Controls.Add(f2);
            f2.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.TopLevel = false;
            panel2.Controls.Add(f2);
            f2.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.TopLevel = false;
            panel2.Controls.Add(f2);
            f2.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.TopLevel = false;
            panel2.Controls.Add(f2);
            f2.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.TopLevel = false;
            panel2.Controls.Add(f2);
            f2.Show();
        }
    }
}
