namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.btnSingIn = new System.Windows.Forms.Button();
            this.usernameLb = new System.Windows.Forms.Label();
            this.passwordLb = new System.Windows.Forms.Label();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.rbArministrator = new System.Windows.Forms.RadioButton();
            this.rbUser = new System.Windows.Forms.RadioButton();
            this.roleLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSingIn
            // 
            this.btnSingIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingIn.Location = new System.Drawing.Point(340, 267);
            this.btnSingIn.Name = "btnSingIn";
            this.btnSingIn.Size = new System.Drawing.Size(90, 31);
            this.btnSingIn.TabIndex = 0;
            this.btnSingIn.Text = "Sing in";
            this.btnSingIn.UseVisualStyleBackColor = true;
            // 
            // usernameLb
            // 
            this.usernameLb.AutoSize = true;
            this.usernameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLb.Location = new System.Drawing.Point(174, 59);
            this.usernameLb.Name = "usernameLb";
            this.usernameLb.Size = new System.Drawing.Size(90, 18);
            this.usernameLb.TabIndex = 1;
            this.usernameLb.Text = "Username:";
            // 
            // passwordLb
            // 
            this.passwordLb.AutoSize = true;
            this.passwordLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLb.Location = new System.Drawing.Point(174, 112);
            this.passwordLb.Name = "passwordLb";
            this.passwordLb.Size = new System.Drawing.Size(88, 18);
            this.passwordLb.TabIndex = 2;
            this.passwordLb.Text = "Password:";
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(318, 95);
            this.passwordTb.Multiline = true;
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(159, 34);
            this.passwordTb.TabIndex = 3;
            // 
            // usernameTb
            // 
            this.usernameTb.Location = new System.Drawing.Point(318, 42);
            this.usernameTb.Multiline = true;
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(159, 35);
            this.usernameTb.TabIndex = 4;
            // 
            // rbArministrator
            // 
            this.rbArministrator.AutoSize = true;
            this.rbArministrator.Location = new System.Drawing.Point(340, 151);
            this.rbArministrator.Name = "rbArministrator";
            this.rbArministrator.Size = new System.Drawing.Size(112, 21);
            this.rbArministrator.TabIndex = 5;
            this.rbArministrator.TabStop = true;
            this.rbArministrator.Text = "Administrator";
            this.rbArministrator.UseVisualStyleBackColor = true;
            // 
            // rbUser
            // 
            this.rbUser.AutoSize = true;
            this.rbUser.Location = new System.Drawing.Point(340, 200);
            this.rbUser.Name = "rbUser";
            this.rbUser.Size = new System.Drawing.Size(59, 21);
            this.rbUser.TabIndex = 6;
            this.rbUser.TabStop = true;
            this.rbUser.Text = "User";
            this.rbUser.UseVisualStyleBackColor = true;
            // 
            // roleLb
            // 
            this.roleLb.AutoSize = true;
            this.roleLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLb.Location = new System.Drawing.Point(189, 155);
            this.roleLb.Name = "roleLb";
            this.roleLb.Size = new System.Drawing.Size(48, 18);
            this.roleLb.TabIndex = 7;
            this.roleLb.Text = "Role:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(625, 356);
            this.Controls.Add(this.roleLb);
            this.Controls.Add(this.rbUser);
            this.Controls.Add(this.rbArministrator);
            this.Controls.Add(this.usernameTb);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.passwordLb);
            this.Controls.Add(this.usernameLb);
            this.Controls.Add(this.btnSingIn);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSingIn;
        private System.Windows.Forms.Label usernameLb;
        private System.Windows.Forms.Label passwordLb;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.RadioButton rbArministrator;
        private System.Windows.Forms.RadioButton rbUser;
        private System.Windows.Forms.Label roleLb;
    }
}