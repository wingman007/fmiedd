namespace CRUD_Project.Views
{
    partial class UserAdminPanel
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnUsername,
            this.columnPassword,
            this.columnEmail,
            this.columnRole});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(8, 86);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(655, 335);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 40;
            // 
            // columnUsername
            // 
            this.columnUsername.Text = "Username";
            this.columnUsername.Width = 120;
            // 
            // columnPassword
            // 
            this.columnPassword.Text = "Password";
            this.columnPassword.Width = 100;
            // 
            // columnEmail
            // 
            this.columnEmail.Text = "E-Mail";
            this.columnEmail.Width = 120;
            // 
            // columnRole
            // 
            this.columnRole.Text = "Role";
            this.columnRole.Width = 100;
            // 
            // metroButton1
            // 
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton1.Location = new System.Drawing.Point(491, 86);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 26);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Edit";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton2.Location = new System.Drawing.Point(587, 86);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 26);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "Delete";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(587, 429);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 26);
            this.metroButton3.TabIndex = 3;
            this.metroButton3.Text = "Exit";
            this.metroButton3.UseSelectable = true;
            // 
            // UserAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.metroButton3;
            this.ClientSize = new System.Drawing.Size(670, 463);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserAdminPanel";
            this.Padding = new System.Windows.Forms.Padding(23, 74, 23, 25);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Admin Panel";
            this.Activated += new System.EventHandler(this.UserAdminPanel_Activated);
            this.Load += new System.EventHandler(this.UserAdminPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnUsername;
        private System.Windows.Forms.ColumnHeader columnPassword;
        private System.Windows.Forms.ColumnHeader columnEmail;
        private System.Windows.Forms.ColumnHeader columnRole;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;




    }
}