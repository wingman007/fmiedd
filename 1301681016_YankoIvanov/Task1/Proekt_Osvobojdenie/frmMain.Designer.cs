namespace Proekt_Osvobojdenie
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsControls = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbtnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnRead = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMemberRead = new System.Windows.Forms.ToolStripButton();
            this.listboxUsers = new System.Windows.Forms.ListBox();
            this.listboxNames = new System.Windows.Forms.ListBox();
            this.listboxPass = new System.Windows.Forms.ListBox();
            this.listboxEmail = new System.Windows.Forms.ListBox();
            this.listboxAdmin = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsControls,
            this.toolStripDropDownButton1,
            this.tsMemberRead});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(992, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsControls
            // 
            this.tsControls.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsControls.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUser,
            this.tsmAbout,
            this.tsmLogout,
            this.tsmExit});
            this.tsControls.Image = ((System.Drawing.Image)(resources.GetObject("tsControls.Image")));
            this.tsControls.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsControls.Name = "tsControls";
            this.tsControls.Size = new System.Drawing.Size(51, 22);
            this.tsControls.Text = "Menu";
            // 
            // tsmUser
            // 
            this.tsmUser.Name = "tsmUser";
            this.tsmUser.Size = new System.Drawing.Size(156, 22);
            this.tsmUser.Text = "User";
            this.tsmUser.Click += new System.EventHandler(this.tsmUser_Click);
            // 
            // tsmAbout
            // 
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.Size = new System.Drawing.Size(156, 22);
            this.tsmAbout.Text = "About Program";
            // 
            // tsmLogout
            // 
            this.tsmLogout.Name = "tsmLogout";
            this.tsmLogout.Size = new System.Drawing.Size(156, 22);
            this.tsmLogout.Text = "Logout";
            this.tsmLogout.Click += new System.EventHandler(this.tsmLogout_Click);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(156, 22);
            this.tsmExit.Text = "Exit";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnNew,
            this.tsbtnRead,
            this.tsbtnEdit,
            this.tsbtnDelete});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(72, 22);
            this.toolStripDropDownButton1.Text = "Functions";
            // 
            // tsbtnNew
            // 
            this.tsbtnNew.Name = "tsbtnNew";
            this.tsbtnNew.Size = new System.Drawing.Size(107, 22);
            this.tsbtnNew.Text = "New";
            this.tsbtnNew.Click += new System.EventHandler(this.tsbtnNew_Click);
            // 
            // tsbtnRead
            // 
            this.tsbtnRead.Name = "tsbtnRead";
            this.tsbtnRead.Size = new System.Drawing.Size(107, 22);
            this.tsbtnRead.Text = "Read";
            this.tsbtnRead.Click += new System.EventHandler(this.tsbtnRead_Click);
            // 
            // tsbtnEdit
            // 
            this.tsbtnEdit.Name = "tsbtnEdit";
            this.tsbtnEdit.Size = new System.Drawing.Size(107, 22);
            this.tsbtnEdit.Text = "Edit";
            this.tsbtnEdit.Click += new System.EventHandler(this.tsbtnEdit_Click);
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(107, 22);
            this.tsbtnDelete.Text = "Delete";
            this.tsbtnDelete.Click += new System.EventHandler(this.tsbtnDelete_Click);
            // 
            // tsMemberRead
            // 
            this.tsMemberRead.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsMemberRead.Image = ((System.Drawing.Image)(resources.GetObject("tsMemberRead.Image")));
            this.tsMemberRead.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMemberRead.Name = "tsMemberRead";
            this.tsMemberRead.Size = new System.Drawing.Size(37, 22);
            this.tsMemberRead.Text = "Read";
            this.tsMemberRead.Click += new System.EventHandler(this.tsMemberRead_Click);
            // 
            // listboxUsers
            // 
            this.listboxUsers.FormattingEnabled = true;
            this.listboxUsers.Location = new System.Drawing.Point(0, 41);
            this.listboxUsers.Name = "listboxUsers";
            this.listboxUsers.Size = new System.Drawing.Size(193, 238);
            this.listboxUsers.TabIndex = 5;
            this.listboxUsers.SelectedIndexChanged += new System.EventHandler(this.listboxUsers_SelectedIndexChanged);
            // 
            // listboxNames
            // 
            this.listboxNames.Enabled = false;
            this.listboxNames.FormattingEnabled = true;
            this.listboxNames.Location = new System.Drawing.Point(199, 41);
            this.listboxNames.Name = "listboxNames";
            this.listboxNames.Size = new System.Drawing.Size(193, 238);
            this.listboxNames.TabIndex = 7;
            // 
            // listboxPass
            // 
            this.listboxPass.Enabled = false;
            this.listboxPass.FormattingEnabled = true;
            this.listboxPass.Location = new System.Drawing.Point(398, 41);
            this.listboxPass.Name = "listboxPass";
            this.listboxPass.Size = new System.Drawing.Size(193, 238);
            this.listboxPass.TabIndex = 8;
            // 
            // listboxEmail
            // 
            this.listboxEmail.Enabled = false;
            this.listboxEmail.FormattingEnabled = true;
            this.listboxEmail.Location = new System.Drawing.Point(597, 41);
            this.listboxEmail.Name = "listboxEmail";
            this.listboxEmail.Size = new System.Drawing.Size(193, 238);
            this.listboxEmail.TabIndex = 9;
            // 
            // listboxAdmin
            // 
            this.listboxAdmin.Enabled = false;
            this.listboxAdmin.FormattingEnabled = true;
            this.listboxAdmin.Location = new System.Drawing.Point(796, 41);
            this.listboxAdmin.Name = "listboxAdmin";
            this.listboxAdmin.Size = new System.Drawing.Size(193, 238);
            this.listboxAdmin.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Usernames:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name and Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(678, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(873, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Admin:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 286);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listboxAdmin);
            this.Controls.Add(this.listboxEmail);
            this.Controls.Add(this.listboxPass);
            this.Controls.Add(this.listboxNames);
            this.Controls.Add(this.listboxUsers);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmMain";
            this.Text = "Admninistration";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ListBox listboxUsers;
        private System.Windows.Forms.ToolStripDropDownButton tsControls;
        private System.Windows.Forms.ToolStripMenuItem tsmUser;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmLogout;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem tsbtnNew;
        private System.Windows.Forms.ToolStripMenuItem tsbtnRead;
        private System.Windows.Forms.ToolStripMenuItem tsbtnEdit;
        private System.Windows.Forms.ToolStripMenuItem tsbtnDelete;
        private System.Windows.Forms.ListBox listboxNames;
        private System.Windows.Forms.ListBox listboxPass;
        private System.Windows.Forms.ListBox listboxEmail;
        private System.Windows.Forms.ListBox listboxAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton tsMemberRead;
    }
}

