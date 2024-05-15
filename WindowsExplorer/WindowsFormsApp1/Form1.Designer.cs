
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoMedium = new System.Windows.Forms.RadioButton();
            this.rdoSmallIcon = new System.Windows.Forms.RadioButton();
            this.rdoLargeIcon = new System.Windows.Forms.RadioButton();
            this.rdoLists = new System.Windows.Forms.RadioButton();
            this.rdoDetails = new System.Windows.Forms.RadioButton();
            this.rdoTiles = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.BackColor = System.Drawing.SystemColors.Info;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList3;
            this.treeView1.Location = new System.Drawing.Point(4, 115);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(149, 392);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect_1);
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "icons8-hdd-48.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-folder-16.png");
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.SystemColors.Info;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.FileType,
            this.FileSize});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList2;
            this.listView1.Location = new System.Drawing.Point(155, 115);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(536, 387);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
         //   this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
          //  this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // FileName
            // 
            this.FileName.Text = "Name";
            this.FileName.Width = 150;
            // 
            // FileType
            // 
            this.FileType.Text = "Type";
            this.FileType.Width = 150;
            // 
            // FileSize
            // 
            this.FileSize.Text = "Size";
            this.FileSize.Width = 150;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.White;
            this.imageList2.Images.SetKeyName(0, "icons8-folder-48.png");
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.rdoMedium);
            this.groupBox1.Controls.Add(this.rdoSmallIcon);
            this.groupBox1.Controls.Add(this.rdoLargeIcon);
            this.groupBox1.Controls.Add(this.rdoLists);
            this.groupBox1.Controls.Add(this.rdoDetails);
            this.groupBox1.Controls.Add(this.rdoTiles);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(236, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 114);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View";
            // 
            // rdoMedium
            // 
            this.rdoMedium.AutoSize = true;
            this.rdoMedium.Location = new System.Drawing.Point(273, 67);
            this.rdoMedium.Name = "rdoMedium";
            this.rdoMedium.Size = new System.Drawing.Size(68, 17);
            this.rdoMedium.TabIndex = 5;
            this.rdoMedium.Text = "Medium";
            this.rdoMedium.UseVisualStyleBackColor = true;
            this.rdoMedium.Click += new System.EventHandler(this.radioButton5_Click);
            // 
            // rdoSmallIcon
            // 
            this.rdoSmallIcon.AutoSize = true;
            this.rdoSmallIcon.Location = new System.Drawing.Point(75, 67);
            this.rdoSmallIcon.Name = "rdoSmallIcon";
            this.rdoSmallIcon.Size = new System.Drawing.Size(80, 17);
            this.rdoSmallIcon.TabIndex = 4;
            this.rdoSmallIcon.Text = "SmallIcon";
            this.rdoSmallIcon.UseVisualStyleBackColor = true;
            this.rdoSmallIcon.Click += new System.EventHandler(this.radioButton5_Click);
            // 
            // rdoLargeIcon
            // 
            this.rdoLargeIcon.AutoSize = true;
            this.rdoLargeIcon.Location = new System.Drawing.Point(173, 67);
            this.rdoLargeIcon.Name = "rdoLargeIcon";
            this.rdoLargeIcon.Size = new System.Drawing.Size(82, 17);
            this.rdoLargeIcon.TabIndex = 3;
            this.rdoLargeIcon.Text = "LargeIcon";
            this.rdoLargeIcon.UseVisualStyleBackColor = true;
            this.rdoLargeIcon.Click += new System.EventHandler(this.radioButton5_Click);
            // 
            // rdoLists
            // 
            this.rdoLists.AutoSize = true;
            this.rdoLists.Location = new System.Drawing.Point(273, 19);
            this.rdoLists.Name = "rdoLists";
            this.rdoLists.Size = new System.Drawing.Size(51, 17);
            this.rdoLists.TabIndex = 2;
            this.rdoLists.Text = "Lists";
            this.rdoLists.UseVisualStyleBackColor = true;
            this.rdoLists.Click += new System.EventHandler(this.radioButton5_Click);
            // 
            // rdoDetails
            // 
            this.rdoDetails.AutoSize = true;
            this.rdoDetails.Checked = true;
            this.rdoDetails.Location = new System.Drawing.Point(173, 19);
            this.rdoDetails.Name = "rdoDetails";
            this.rdoDetails.Size = new System.Drawing.Size(64, 17);
            this.rdoDetails.TabIndex = 1;
            this.rdoDetails.TabStop = true;
            this.rdoDetails.Text = "Details";
            this.rdoDetails.UseVisualStyleBackColor = true;
            this.rdoDetails.Click += new System.EventHandler(this.radioButton5_Click);
            // 
            // rdoTiles
            // 
            this.rdoTiles.AutoSize = true;
            this.rdoTiles.Location = new System.Drawing.Point(75, 19);
            this.rdoTiles.Name = "rdoTiles";
            this.rdoTiles.Size = new System.Drawing.Size(52, 17);
            this.rdoTiles.TabIndex = 0;
            this.rdoTiles.Text = "Tiles";
            this.rdoTiles.UseVisualStyleBackColor = true;
           // this.rdoTiles.CheckedChanged += new System.EventHandler(this.rdoTiles_CheckedChanged);
            this.rdoTiles.Click += new System.EventHandler(this.radioButton5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Location = new System.Drawing.Point(4, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 114);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 519);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoTiles;
        private System.Windows.Forms.RadioButton rdoMedium;
        private System.Windows.Forms.RadioButton rdoSmallIcon;
        private System.Windows.Forms.RadioButton rdoLargeIcon;
        private System.Windows.Forms.RadioButton rdoLists;
        private System.Windows.Forms.RadioButton rdoDetails;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader FileType;
        private System.Windows.Forms.ColumnHeader FileSize;
    }
}

