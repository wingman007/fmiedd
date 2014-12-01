namespace Task
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
            this.tsMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsMenuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAdministration = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsAdminstrAdministration = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenu,
            this.tsAdministration});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1184, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsMenu
            // 
            this.tsMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuUser,
            this.tsMenuAbout,
            this.tsMenuLogout,
            this.tsMenuExit});
            this.tsMenu.Image = ((System.Drawing.Image)(resources.GetObject("tsMenu.Image")));
            this.tsMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(51, 22);
            this.tsMenu.Text = "Menu";
            // 
            // tsMenuUser
            // 
            this.tsMenuUser.Name = "tsMenuUser";
            this.tsMenuUser.Size = new System.Drawing.Size(156, 22);
            this.tsMenuUser.Text = "About User";
            this.tsMenuUser.Click += new System.EventHandler(this.tsMenuUser_Click);
            // 
            // tsMenuAbout
            // 
            this.tsMenuAbout.Name = "tsMenuAbout";
            this.tsMenuAbout.Size = new System.Drawing.Size(156, 22);
            this.tsMenuAbout.Text = "About Program";
            // 
            // tsMenuLogout
            // 
            this.tsMenuLogout.Name = "tsMenuLogout";
            this.tsMenuLogout.Size = new System.Drawing.Size(156, 22);
            this.tsMenuLogout.Text = "Logout";
            this.tsMenuLogout.Click += new System.EventHandler(this.tsMenuLogout_Click);
            // 
            // tsMenuExit
            // 
            this.tsMenuExit.Name = "tsMenuExit";
            this.tsMenuExit.Size = new System.Drawing.Size(156, 22);
            this.tsMenuExit.Text = "Exit";
            this.tsMenuExit.Click += new System.EventHandler(this.tsMenuExit_Click);
            // 
            // tsAdministration
            // 
            this.tsAdministration.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsAdministration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdminstrAdministration});
            this.tsAdministration.Image = ((System.Drawing.Image)(resources.GetObject("tsAdministration.Image")));
            this.tsAdministration.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAdministration.Name = "tsAdministration";
            this.tsAdministration.Size = new System.Drawing.Size(125, 22);
            this.tsAdministration.Text = "User Administration";
            // 
            // tsAdminstrAdministration
            // 
            this.tsAdminstrAdministration.Name = "tsAdminstrAdministration";
            this.tsAdminstrAdministration.Size = new System.Drawing.Size(153, 22);
            this.tsAdminstrAdministration.Text = "Administration";
            this.tsAdminstrAdministration.Click += new System.EventHandler(this.tsAdminstrAdministration_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 862);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Main Form";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsMenuUser;
        private System.Windows.Forms.ToolStripMenuItem tsMenuAbout;
        private System.Windows.Forms.ToolStripMenuItem tsMenuLogout;
        private System.Windows.Forms.ToolStripMenuItem tsMenuExit;
        private System.Windows.Forms.ToolStripDropDownButton tsAdministration;
        private System.Windows.Forms.ToolStripMenuItem tsAdminstrAdministration;
    }
}

