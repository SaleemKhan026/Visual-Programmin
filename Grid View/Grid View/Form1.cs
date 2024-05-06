using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grid_View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("[1]");
            dt.Rows.Add("a","b","c","d");



        }

        private void btnload_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(Int32));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Class", typeof(string));
            dt.Columns.Add("Section", typeof(string));
            dt.Columns.Add("Name", typeof(string));


        }
    }
}
