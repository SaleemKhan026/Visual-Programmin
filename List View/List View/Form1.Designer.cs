
namespace List_View
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RollNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Class = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Section = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageLargeIcon = new System.Windows.Forms.ImageList(this.components);
            this.imageSmallIcon = new System.Windows.Forms.ImageList(this.components);
            this.textName = new System.Windows.Forms.TextBox();
            this.textRollno = new System.Windows.Forms.TextBox();
            this.textClass = new System.Windows.Forms.TextBox();
            this.textSection = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.rdoSmallIcon = new System.Windows.Forms.RadioButton();
            this.rdoLargeIcon = new System.Windows.Forms.RadioButton();
            this.rdoDetails = new System.Windows.Forms.RadioButton();
            this.rdoTiles = new System.Windows.Forms.RadioButton();
            this.rdoList = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.AllowColumnReorder = true;
            this.listView.BackColor = System.Drawing.SystemColors.GrayText;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.RollNo,
            this.Class,
            this.Section});
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView.LargeImageList = this.imageLargeIcon;
            this.listView.Location = new System.Drawing.Point(1, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(529, 428);
            this.listView.SmallImageList = this.imageSmallIcon;
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 100;
            // 
            // RollNo
            // 
            this.RollNo.Text = "Roll No";
            this.RollNo.Width = 100;
            // 
            // Class
            // 
            this.Class.Text = "Class";
            this.Class.Width = 100;
            // 
            // Section
            // 
            this.Section.Text = "Section";
            this.Section.Width = 100;
            // 
            // imageLargeIcon
            // 
            this.imageLargeIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageLargeIcon.ImageStream")));
            this.imageLargeIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imageLargeIcon.Images.SetKeyName(0, "icons8-student-48.png");
            this.imageLargeIcon.Images.SetKeyName(1, "icons8-student-48.png");
            // 
            // imageSmallIcon
            // 
            this.imageSmallIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageSmallIcon.ImageStream")));
            this.imageSmallIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imageSmallIcon.Images.SetKeyName(0, "icons8-student-16.png");
            // 
            // textName
            // 
            this.textName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textName.Location = new System.Drawing.Point(621, 28);
            this.textName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(166, 20);
            this.textName.TabIndex = 1;
            // 
            // textRollno
            // 
            this.textRollno.Location = new System.Drawing.Point(620, 66);
            this.textRollno.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textRollno.Name = "textRollno";
            this.textRollno.Size = new System.Drawing.Size(166, 20);
            this.textRollno.TabIndex = 2;
            // 
            // textClass
            // 
            this.textClass.Location = new System.Drawing.Point(619, 105);
            this.textClass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textClass.Name = "textClass";
            this.textClass.Size = new System.Drawing.Size(166, 20);
            this.textClass.TabIndex = 3;
            // 
            // textSection
            // 
            this.textSection.Location = new System.Drawing.Point(619, 141);
            this.textSection.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textSection.Name = "textSection";
            this.textSection.Size = new System.Drawing.Size(166, 20);
            this.textSection.TabIndex = 4;
            this.textSection.TextChanged += new System.EventHandler(this.textSection_TextChanged);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(610, 183);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(74, 31);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(709, 183);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 31);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rdoSmallIcon
            // 
            this.rdoSmallIcon.AutoSize = true;
            this.rdoSmallIcon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoSmallIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSmallIcon.ForeColor = System.Drawing.Color.Yellow;
            this.rdoSmallIcon.Location = new System.Drawing.Point(610, 243);
            this.rdoSmallIcon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdoSmallIcon.Name = "rdoSmallIcon";
            this.rdoSmallIcon.Size = new System.Drawing.Size(94, 20);
            this.rdoSmallIcon.TabIndex = 7;
            this.rdoSmallIcon.Text = "SmallIcon";
            this.rdoSmallIcon.UseVisualStyleBackColor = false;
            this.rdoSmallIcon.Click += new System.EventHandler(this.rdoList_Click);
            // 
            // rdoLargeIcon
            // 
            this.rdoLargeIcon.AutoSize = true;
            this.rdoLargeIcon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoLargeIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLargeIcon.ForeColor = System.Drawing.Color.Yellow;
            this.rdoLargeIcon.Location = new System.Drawing.Point(609, 283);
            this.rdoLargeIcon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdoLargeIcon.Name = "rdoLargeIcon";
            this.rdoLargeIcon.Size = new System.Drawing.Size(95, 20);
            this.rdoLargeIcon.TabIndex = 8;
            this.rdoLargeIcon.Text = "LargeIcon";
            this.rdoLargeIcon.UseVisualStyleBackColor = false;
            this.rdoLargeIcon.Click += new System.EventHandler(this.rdoList_Click);
            // 
            // rdoDetails
            // 
            this.rdoDetails.AutoSize = true;
            this.rdoDetails.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoDetails.Checked = true;
            this.rdoDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDetails.ForeColor = System.Drawing.Color.Yellow;
            this.rdoDetails.Location = new System.Drawing.Point(610, 317);
            this.rdoDetails.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdoDetails.Name = "rdoDetails";
            this.rdoDetails.Size = new System.Drawing.Size(75, 20);
            this.rdoDetails.TabIndex = 9;
            this.rdoDetails.TabStop = true;
            this.rdoDetails.Text = "Details";
            this.rdoDetails.UseVisualStyleBackColor = false;
            this.rdoDetails.Click += new System.EventHandler(this.rdoList_Click);
            // 
            // rdoTiles
            // 
            this.rdoTiles.AutoSize = true;
            this.rdoTiles.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoTiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTiles.ForeColor = System.Drawing.Color.Yellow;
            this.rdoTiles.Location = new System.Drawing.Point(610, 354);
            this.rdoTiles.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdoTiles.Name = "rdoTiles";
            this.rdoTiles.Size = new System.Drawing.Size(61, 20);
            this.rdoTiles.TabIndex = 10;
            this.rdoTiles.Text = "Tiles";
            this.rdoTiles.UseVisualStyleBackColor = false;
            this.rdoTiles.Click += new System.EventHandler(this.rdoList_Click);
            // 
            // rdoList
            // 
            this.rdoList.AutoSize = true;
            this.rdoList.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoList.ForeColor = System.Drawing.Color.Yellow;
            this.rdoList.Location = new System.Drawing.Point(610, 389);
            this.rdoList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdoList.Name = "rdoList";
            this.rdoList.Size = new System.Drawing.Size(50, 20);
            this.rdoList.TabIndex = 11;
            this.rdoList.Text = "List";
            this.rdoList.UseVisualStyleBackColor = false;
            this.rdoList.Click += new System.EventHandler(this.rdoList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(548, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(548, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Roll No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(549, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(548, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Section";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(790, 430);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdoList);
            this.Controls.Add(this.rdoTiles);
            this.Controls.Add(this.rdoDetails);
            this.Controls.Add(this.rdoLargeIcon);
            this.Controls.Add(this.rdoSmallIcon);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.textSection);
            this.Controls.Add(this.textClass);
            this.Controls.Add(this.textRollno);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.listView);
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
          //  this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textRollno;
        private System.Windows.Forms.TextBox textClass;
        private System.Windows.Forms.TextBox textSection;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rdoSmallIcon;
        private System.Windows.Forms.RadioButton rdoLargeIcon;
        private System.Windows.Forms.RadioButton rdoDetails;
        private System.Windows.Forms.RadioButton rdoTiles;
        private System.Windows.Forms.RadioButton rdoList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private new System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader RollNo;
        private System.Windows.Forms.ColumnHeader Class;
        private System.Windows.Forms.ColumnHeader Section;
        private System.Windows.Forms.ImageList imageSmallIcon;
        private System.Windows.Forms.ImageList imageLargeIcon;
    }
}

