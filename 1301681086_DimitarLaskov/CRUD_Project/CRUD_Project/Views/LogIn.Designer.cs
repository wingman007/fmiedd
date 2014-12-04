namespace CRUD_Project.View
{
    partial class LogIn
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
            this.groupBoxLogIn = new System.Windows.Forms.GroupBox();
            this.textBoxUsername = new MetroFramework.Controls.MetroTextBox();
            this.ButtonLogIn = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.textBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBoxLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLogIn
            // 
            this.groupBoxLogIn.AutoSize = true;
            this.groupBoxLogIn.Controls.Add(this.metroLabel2);
            this.groupBoxLogIn.Controls.Add(this.metroLabel1);
            this.groupBoxLogIn.Controls.Add(this.textBoxPassword);
            this.groupBoxLogIn.Controls.Add(this.textBoxUsername);
            this.groupBoxLogIn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxLogIn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBoxLogIn.Location = new System.Drawing.Point(23, 55);
            this.groupBoxLogIn.Name = "groupBoxLogIn";
            this.groupBoxLogIn.Size = new System.Drawing.Size(221, 139);
            this.groupBoxLogIn.TabIndex = 6;
            this.groupBoxLogIn.TabStop = false;
            this.groupBoxLogIn.Text = "Sign Up";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Lines = new string[0];
            this.textBoxUsername.Location = new System.Drawing.Point(42, 44);
            this.textBoxUsername.MaxLength = 32767;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.PasswordChar = '\0';
            this.textBoxUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxUsername.SelectedText = "";
            this.textBoxUsername.Size = new System.Drawing.Size(135, 23);
            this.textBoxUsername.TabIndex = 10;
            this.textBoxUsername.UseSelectable = true;
            // 
            // ButtonLogIn
            // 
            this.ButtonLogIn.DisplayFocus = true;
            this.ButtonLogIn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ButtonLogIn.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.ButtonLogIn.Location = new System.Drawing.Point(23, 208);
            this.ButtonLogIn.Name = "ButtonLogIn";
            this.ButtonLogIn.Size = new System.Drawing.Size(98, 25);
            this.ButtonLogIn.Style = MetroFramework.MetroColorStyle.Green;
            this.ButtonLogIn.TabIndex = 8;
            this.ButtonLogIn.Text = "Log In";
            this.ButtonLogIn.UseSelectable = true;
            this.ButtonLogIn.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.DisplayFocus = true;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton1.Location = new System.Drawing.Point(167, 208);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(77, 25);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "Register";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Lines = new string[0];
            this.textBoxPassword.Location = new System.Drawing.Point(42, 92);
            this.textBoxPassword.MaxLength = 32767;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '●';
            this.textBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.Size = new System.Drawing.Size(135, 23);
            this.textBoxPassword.TabIndex = 11;
            this.textBoxPassword.UseSelectable = true;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Enabled = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
            this.metroLabel1.Location = new System.Drawing.Point(42, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(61, 15);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Username:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Enabled = false;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
            this.metroLabel2.Location = new System.Drawing.Point(40, 74);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 15);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Password:";
            // 
            // LogIn
            // 
            this.AcceptButton = this.ButtonLogIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(267, 252);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.ButtonLogIn);
            this.Controls.Add(this.groupBoxLogIn);
            this.MaximizeBox = false;
            this.Name = "LogIn";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "My Movie Catalogue";
            this.groupBoxLogIn.ResumeLayout(false);
            this.groupBoxLogIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLogIn;
        private MetroFramework.Controls.MetroButton ButtonLogIn;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox textBoxUsername;
        private MetroFramework.Controls.MetroTextBox textBoxPassword;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}

