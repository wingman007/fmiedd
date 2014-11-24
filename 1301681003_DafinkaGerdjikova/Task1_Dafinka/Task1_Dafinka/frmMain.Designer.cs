namespace Task1_Dafinka
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsUsers = new System.Windows.Forms.ToolStripButton();
            this.tsRoles = new System.Windows.Forms.ToolStripButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.task1DataSet = new Task1_Dafinka.task1DataSet();
            this.usersTableAdapter = new Task1_Dafinka.task1DataSetTableAdapters.UsersTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.task1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsUsers,
            this.tsRoles});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(760, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsUsers
            // 
            this.tsUsers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsUsers.Image = ((System.Drawing.Image)(resources.GetObject("tsUsers.Image")));
            this.tsUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUsers.Name = "tsUsers";
            this.tsUsers.Size = new System.Drawing.Size(39, 22);
            this.tsUsers.Text = "Users";
            this.tsUsers.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsRoles
            // 
            this.tsRoles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsRoles.Image = ((System.Drawing.Image)(resources.GetObject("tsRoles.Image")));
            this.tsRoles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRoles.Name = "tsRoles";
            this.tsRoles.Size = new System.Drawing.Size(39, 22);
            this.tsRoles.Text = "Roles";
            this.tsRoles.Click += new System.EventHandler(this.tsRoles_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Users";
            this.bindingSource1.DataSource = this.task1DataSet;
            // 
            // task1DataSet
            // 
            this.task1DataSet.DataSetName = "task1DataSet";
            this.task1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(760, 541);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmMain";
            this.Text = "Main form";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.task1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private task1DataSet task1DataSet;
        private task1DataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.ToolStripButton tsUsers;
        private System.Windows.Forms.ToolStripButton tsRoles;

    }
}

