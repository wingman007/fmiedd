namespace CRUD_Project.Views
{
    partial class EditUser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroRadioButton3 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.textBoxEmail = new MetroFramework.Controls.MetroTextBox();
            this.textBoxPass = new MetroFramework.Controls.MetroTextBox();
            this.textBoxUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonRegister = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroRadioButton3);
            this.groupBox1.Controls.Add(this.metroRadioButton2);
            this.groupBox1.Controls.Add(this.metroRadioButton1);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.textBoxPass);
            this.groupBox1.Controls.Add(this.textBoxUsername);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(35, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 291);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // metroRadioButton3
            // 
            this.metroRadioButton3.AutoSize = true;
            this.metroRadioButton3.ForeColor = System.Drawing.Color.Silver;
            this.metroRadioButton3.Location = new System.Drawing.Point(37, 258);
            this.metroRadioButton3.Name = "metroRadioButton3";
            this.metroRadioButton3.Size = new System.Drawing.Size(59, 15);
            this.metroRadioButton3.TabIndex = 15;
            this.metroRadioButton3.Text = "Admin";
            this.metroRadioButton3.UseSelectable = true;
            this.metroRadioButton3.CheckedChanged += new System.EventHandler(this.metroRadioButton3_CheckedChanged);
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.ForeColor = System.Drawing.Color.Silver;
            this.metroRadioButton2.Location = new System.Drawing.Point(37, 239);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(68, 15);
            this.metroRadioButton2.TabIndex = 14;
            this.metroRadioButton2.Text = "Member";
            this.metroRadioButton2.UseSelectable = true;
            this.metroRadioButton2.CheckedChanged += new System.EventHandler(this.metroRadioButton2_CheckedChanged);
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.ForeColor = System.Drawing.Color.Silver;
            this.metroRadioButton1.Location = new System.Drawing.Point(37, 218);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(56, 15);
            this.metroRadioButton1.TabIndex = 13;
            this.metroRadioButton1.Text = "Public";
            this.metroRadioButton1.UseSelectable = true;
            this.metroRadioButton1.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Enabled = false;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.Location = new System.Drawing.Point(32, 191);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(58, 15);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "User Role:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Enabled = false;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.Location = new System.Drawing.Point(35, 138);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(41, 15);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "E-Mail:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Enabled = false;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.Location = new System.Drawing.Point(33, 84);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 15);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Password:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Enabled = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(32, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(61, 15);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Username:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Lines = new string[0];
            this.textBoxEmail.Location = new System.Drawing.Point(32, 156);
            this.textBoxEmail.MaxLength = 32767;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PasswordChar = '\0';
            this.textBoxEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxEmail.SelectedText = "";
            this.textBoxEmail.Size = new System.Drawing.Size(122, 23);
            this.textBoxEmail.TabIndex = 8;
            this.textBoxEmail.UseSelectable = true;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Lines = new string[0];
            this.textBoxPass.Location = new System.Drawing.Point(33, 102);
            this.textBoxPass.MaxLength = 32767;
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '\0';
            this.textBoxPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxPass.SelectedText = "";
            this.textBoxPass.Size = new System.Drawing.Size(122, 23);
            this.textBoxPass.TabIndex = 7;
            this.textBoxPass.UseSelectable = true;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Lines = new string[0];
            this.textBoxUsername.Location = new System.Drawing.Point(33, 48);
            this.textBoxUsername.MaxLength = 32767;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.PasswordChar = '\0';
            this.textBoxUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxUsername.SelectedText = "";
            this.textBoxUsername.Size = new System.Drawing.Size(122, 23);
            this.textBoxUsername.TabIndex = 6;
            this.textBoxUsername.UseSelectable = true;
            // 
            // metroButtonRegister
            // 
            this.metroButtonRegister.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButtonRegister.Location = new System.Drawing.Point(36, 379);
            this.metroButtonRegister.Name = "metroButtonRegister";
            this.metroButtonRegister.Size = new System.Drawing.Size(75, 23);
            this.metroButtonRegister.TabIndex = 4;
            this.metroButtonRegister.Text = "Edit";
            this.metroButtonRegister.UseSelectable = true;
            this.metroButtonRegister.Click += new System.EventHandler(this.metroButtonRegister_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton1.Location = new System.Drawing.Point(149, 379);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Cancel";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // EditUser
            // 
            this.AcceptButton = this.metroButtonRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.metroButton1;
            this.ClientSize = new System.Drawing.Size(261, 427);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroButtonRegister);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditUser";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Edit User";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox textBoxUsername;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox textBoxEmail;
        private MetroFramework.Controls.MetroTextBox textBoxPass;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButtonRegister;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton3;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
    }
}