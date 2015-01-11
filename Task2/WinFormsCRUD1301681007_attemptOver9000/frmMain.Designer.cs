namespace WinFormsCRUD1301681007_attemptOver9000
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdministration = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMainAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMainExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMainView = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMainAdministration = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMainView,
            this.btnMainAdministration});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(883, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuView
            // 
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(45, 20);
            this.mnuView.Text = "View";
            // 
            // mnuAdministration
            // 
            this.mnuAdministration.Name = "mnuAdministration";
            this.mnuAdministration.Size = new System.Drawing.Size(95, 20);
            this.mnuAdministration.Text = "Administration";
            this.mnuAdministration.Click += new System.EventHandler(this.mnuAdministration_Click);
            // 
            // btnMainAbout
            // 
            this.btnMainAbout.Name = "btnMainAbout";
            this.btnMainAbout.Size = new System.Drawing.Size(152, 22);
            this.btnMainAbout.Text = "About";
            this.btnMainAbout.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnMainExit
            // 
            this.btnMainExit.Name = "btnMainExit";
            this.btnMainExit.Size = new System.Drawing.Size(152, 22);
            this.btnMainExit.Text = "Exit";
            this.btnMainExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnMainView
            // 
            this.btnMainView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.btnMainView.Name = "btnMainView";
            this.btnMainView.Size = new System.Drawing.Size(45, 20);
            this.btnMainView.Text = "View";
            this.btnMainView.Click += new System.EventHandler(this.btnMainView_Click);
            // 
            // btnMainAdministration
            // 
            this.btnMainAdministration.Name = "btnMainAdministration";
            this.btnMainAdministration.Size = new System.Drawing.Size(95, 20);
            this.btnMainAdministration.Text = "Administration";
            this.btnMainAdministration.Click += new System.EventHandler(this.btnMainAdministration_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(883, 539);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Simple CRUD Application";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministration;
        private System.Windows.Forms.ToolStripMenuItem btnMainAbout;
        private System.Windows.Forms.ToolStripMenuItem btnMainExit;
        private System.Windows.Forms.ToolStripMenuItem btnMainView;
        private System.Windows.Forms.ToolStripMenuItem btnMainAdministration;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}