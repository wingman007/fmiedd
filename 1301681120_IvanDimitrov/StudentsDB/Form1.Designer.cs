namespace StudentsDB
{
    partial class formLoading
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
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUserLogin = new System.Windows.Forms.TextBox();
            this.tbPwdLogin = new System.Windows.Forms.TextBox();
            this.btnSignUP = new System.Windows.Forms.Button();
            this.usersTableAdapter = new StudentsDB.StudentsDSTableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cornsilk;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Myriad Pro Cond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.CadetBlue;
            this.button1.Location = new System.Drawing.Point(126, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Myriad Pro Light", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(120, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hello, guest!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Myriad Pro Light", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(122, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "To start the application you need to login...";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Myriad Pro Light", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(122, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Myriad Pro Light", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(123, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password:";
            // 
            // tbUserLogin
            // 
            this.tbUserLogin.AccessibleDescription = "";
            this.tbUserLogin.Location = new System.Drawing.Point(219, 132);
            this.tbUserLogin.Name = "tbUserLogin";
            this.tbUserLogin.Size = new System.Drawing.Size(186, 20);
            this.tbUserLogin.TabIndex = 6;
            this.tbUserLogin.Tag = "";
            this.tbUserLogin.WordWrap = false;
            this.tbUserLogin.Enter += new System.EventHandler(this.tbUserLogin_Enter);
            this.tbUserLogin.Leave += new System.EventHandler(this.tbUserLogin_Leave);
            // 
            // tbPwdLogin
            // 
            this.tbPwdLogin.Location = new System.Drawing.Point(219, 173);
            this.tbPwdLogin.Name = "tbPwdLogin";
            this.tbPwdLogin.Size = new System.Drawing.Size(186, 20);
            this.tbPwdLogin.TabIndex = 7;
            this.tbPwdLogin.Enter += new System.EventHandler(this.tbPwdLogin_Enter);
            this.tbPwdLogin.Leave += new System.EventHandler(this.tbPwdLogin_Leave);
            // 
            // btnSignUP
            // 
            this.btnSignUP.BackColor = System.Drawing.Color.Cornsilk;
            this.btnSignUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUP.Font = new System.Drawing.Font("Myriad Pro Cond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUP.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnSignUP.Location = new System.Drawing.Point(304, 211);
            this.btnSignUP.Name = "btnSignUP";
            this.btnSignUP.Size = new System.Drawing.Size(101, 50);
            this.btnSignUP.TabIndex = 8;
            this.btnSignUP.Text = "SIGN UP";
            this.btnSignUP.UseVisualStyleBackColor = false;
            this.btnSignUP.Click += new System.EventHandler(this.btnSignUP_Click);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // formLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(537, 402);
            this.Controls.Add(this.btnSignUP);
            this.Controls.Add(this.tbPwdLogin);
            this.Controls.Add(this.tbUserLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximumSize = new System.Drawing.Size(553, 441);
            this.MinimumSize = new System.Drawing.Size(553, 441);
            this.Name = "formLoading";
            this.ShowIcon = false;
            this.Text = "Simple Users Control Kit (S.U.C.K.)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formLoading_FormClosing);
            this.Load += new System.EventHandler(this.formLoading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource studentsBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUserLogin;
        private System.Windows.Forms.TextBox tbPwdLogin;
        private System.Windows.Forms.Button btnSignUP;
        private StudentsDSTableAdapters.UsersTableAdapter usersTableAdapter;
    }
}

