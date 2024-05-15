using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadDirectories()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo di in drives)
            {
                TreeNode tnode = new TreeNode();
                tnode.ImageIndex = 0;
                tnode.Text = di.VolumeLabel + " " + di.Name;
                tnode.Tag = di.RootDirectory;
                treeView1.Nodes.Add(tnode);
                LoadChilds(tnode, di.RootDirectory);
            }
        }

        private void LoadChilds(TreeNode tnode, DirectoryInfo directory)
        {
            try
            {
                DirectoryInfo[] folders = directory.GetDirectories();
                foreach (DirectoryInfo folder in folders)
                {
                    TreeNode nd = new TreeNode();
                    nd.ImageIndex = 0;
                    nd.Text = folder.Name;
                    nd.Tag = folder;
                    tnode.Nodes.Add(nd);
                    if (folder.GetDirectories().Count() > 0)
                    {
                        TreeNode demoNode = new TreeNode();
                        demoNode.Text = "New Folder";
                        demoNode.Tag = "DemoNode";
                        nd.Nodes.Add(demoNode);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode tnode = e.Node;

            //show subfolders in left pane
            if (tnode.Nodes.Count > 0 && tnode.Nodes[0].Tag.ToString() == "DemoNode")
            {
                tnode.Nodes.RemoveAt(0);
                DirectoryInfo folder = (DirectoryInfo)tnode.Tag;
                DirectoryInfo[] folders = folder.GetDirectories();
                foreach (DirectoryInfo di in folders)
                {
                    TreeNode nd = new TreeNode();
                    nd.Text = di.Name;
                    nd.Tag = di;
                    tnode.Nodes.Add(nd);
                    if (di.GetDirectories().Count() > 0)
                    {
                        TreeNode demoNode = new TreeNode();
                        demoNode.Text = "New Folder";
                        demoNode.Tag = "DemoNode";
                        nd.Nodes.Add(demoNode);
                    }
                }
            }

            //show contents in right pane (listview)
            DirectoryInfo diDetails = (DirectoryInfo)tnode.Tag;
            FileInfo[] files = diDetails.GetFiles();
            listView1.Items.Clear();
            foreach (FileInfo file in files)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = 0;
                item.Text = file.Name;
                listView1.Items.Add(item);

            }



        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

            try
            {
                TreeNode selectedNode = e.Node;
                DirectoryInfo selectedDir = (DirectoryInfo)selectedNode.Tag;
                listView1.Items.Clear();

                foreach (var dir in selectedDir.GetDirectories())
                {
                    ListViewItem item = new ListViewItem(dir.Name);
                    item.ImageIndex = 0;
                    item.SubItems.Add("Folder");
                    item.Tag = "folder";
                    listView1.Items.Add(item);
                }

                foreach (var file in selectedDir.GetFiles())
                {
                    ListViewItem item = new ListViewItem(file.Name);
                    item.ImageIndex = 0;
                    item.SubItems.Add("File");
                    item.ImageKey = "file";
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDirectories();
            ListViewItem item = new ListViewItem();
            item.ImageIndex = 0;
        }
    
        private void radioButton5_Click(object sender, EventArgs e)
        {

            RadioButton rbtn = (RadioButton)sender;
            switch (rbtn.Name)
            {

                case "rdoLargeIcon": listView1.View = View.LargeIcon; break;
                case "rdoSmallIcon": listView1.View = View.SmallIcon; break;
                case "rdoDetails": listView1.View = View.Details; break;
                case "rdoTiles": listView1.View = View.Tile; break;
                case "rdoLists": listView1.View = View.List; break;
                case "rdoMedium": listView1.View = View.List; break;

            }


        }


      
    }
}

