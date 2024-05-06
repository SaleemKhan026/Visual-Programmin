using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string a;
        private void Form1_Load(object sender, EventArgs e)
        {

                DataTable dt = new DataTable();
                dt.Columns.Add("RollNo", typeof(Int32));
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("Class", typeof(string));
                dt.Columns.Add("Section", typeof(string));
                dt.Rows.Add(1, "USAMA", "BsCs", "5th");
                dt.Rows.Add(2, "ADNAN", "BsCs", "5th");
                dt.Rows.Add(3, "ABID", "BsCs", "5th");
                dt.Rows.Add(4, "SALEEM", "BsCs", "5th");

                listView.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {

                    ListViewItem item = new ListViewItem();
                      item.ImageIndex= 0;
                item.Text = row["RollNo"].ToString();
                    item.SubItems.Add(row["Name"].ToString());
                    item.SubItems.Add(row["Class"].ToString());
                    item.SubItems.Add(row["Section"].ToString());

                    listView.Items.Add(item);
                }
            }

            private void listView_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (listView.SelectedItems.Count > 0)
                {
                    ListViewItem itm = listView.SelectedItems[0];
                    textName.Text = itm.Text;
                    textName.Text = itm.SubItems[1].Text;
                    textClass.Text = itm.SubItems[2].Text;
                    textSection.Text = itm.SubItems[3].Text;
                }
            }

            private void btnNew_Click(object sender, EventArgs e)
            {
                textRollno.Text="";
                textName.Text= "";
                textClass.Text = "";
                textSection.Text = "";
            }

            private void btnSave_Click(object sender, EventArgs e)
            {
                ListViewItem item = new ListViewItem();
                item.Text = textRollno.Text;
                item.SubItems.Add(textName.Text);
                item.SubItems.Add(textClass.Text);
                item.SubItems.Add(textSection.Text);
                listView.Items.Add(item);
            }

        private void rdoList_Click(object sender, EventArgs e)
        {
            RadioButton rbtn = (RadioButton)sender;
            switch (rbtn.Name)
            {
                case "rdoLargeIcon": listView.View = View.LargeIcon; break;
                case "rdoSmallIcon": listView.View = View.SmallIcon; break;
                case "rdoDetails": listView.View = View.Details; break;
                case "rdoTiles": listView.View = View.Tile; break;
                case "rdoList": listView.View = View.List; break;
            }
        }

        private void textSection_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
