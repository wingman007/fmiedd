namespace LASTtry
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_crt = new System.Windows.Forms.Button();
            this.txbemail = new System.Windows.Forms.TextBox();
            this.txbpass = new System.Windows.Forms.TextBox();
            this.txbuser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_upd = new System.Windows.Forms.Button();
            this.temail = new System.Windows.Forms.TextBox();
            this.tpass = new System.Windows.Forms.TextBox();
            this.tuser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_fill = new System.Windows.Forms.Button();
            this.cmb_per = new System.Windows.Forms.ComboBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_crt);
            this.groupBox1.Controls.Add(this.txbemail);
            this.groupBox1.Controls.Add(this.txbpass);
            this.groupBox1.Controls.Add(this.txbuser);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create";
            // 
            // btn_crt
            // 
            this.btn_crt.Location = new System.Drawing.Point(102, 142);
            this.btn_crt.Name = "btn_crt";
            this.btn_crt.Size = new System.Drawing.Size(100, 25);
            this.btn_crt.TabIndex = 8;
            this.btn_crt.Text = "Create";
            this.btn_crt.UseVisualStyleBackColor = true;
            this.btn_crt.Click += new System.EventHandler(this.btn_crt_Click);
            // 
            // txbemail
            // 
            this.txbemail.Location = new System.Drawing.Point(102, 103);
            this.txbemail.Name = "txbemail";
            this.txbemail.Size = new System.Drawing.Size(100, 20);
            this.txbemail.TabIndex = 7;
            // 
            // txbpass
            // 
            this.txbpass.Location = new System.Drawing.Point(102, 77);
            this.txbpass.Name = "txbpass";
            this.txbpass.Size = new System.Drawing.Size(100, 20);
            this.txbpass.TabIndex = 6;
            // 
            // txbuser
            // 
            this.txbuser.BackColor = System.Drawing.SystemColors.Window;
            this.txbuser.Location = new System.Drawing.Point(102, 48);
            this.txbuser.Name = "txbuser";
            this.txbuser.Size = new System.Drawing.Size(100, 20);
            this.txbuser.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "username";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Close);
            this.groupBox2.Controls.Add(this.btn_del);
            this.groupBox2.Controls.Add(this.btn_upd);
            this.groupBox2.Controls.Add(this.temail);
            this.groupBox2.Controls.Add(this.tpass);
            this.groupBox2.Controls.Add(this.tuser);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btn_fill);
            this.groupBox2.Controls.Add(this.cmb_per);
            this.groupBox2.Location = new System.Drawing.Point(248, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 218);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Retrieve, Update , Delete";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(180, 53);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 13;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_upd
            // 
            this.btn_upd.Location = new System.Drawing.Point(86, 186);
            this.btn_upd.Name = "btn_upd";
            this.btn_upd.Size = new System.Drawing.Size(75, 23);
            this.btn_upd.TabIndex = 12;
            this.btn_upd.Text = "Update";
            this.btn_upd.UseVisualStyleBackColor = true;
            this.btn_upd.Click += new System.EventHandler(this.btn_upd_Click);
            // 
            // temail
            // 
            this.temail.Location = new System.Drawing.Point(61, 160);
            this.temail.Name = "temail";
            this.temail.Size = new System.Drawing.Size(100, 20);
            this.temail.TabIndex = 11;
            // 
            // tpass
            // 
            this.tpass.Location = new System.Drawing.Point(61, 134);
            this.tpass.Name = "tpass";
            this.tpass.Size = new System.Drawing.Size(100, 20);
            this.tpass.TabIndex = 10;
            // 
            // tuser
            // 
            this.tuser.Location = new System.Drawing.Point(61, 105);
            this.tuser.Name = "tuser";
            this.tuser.Size = new System.Drawing.Size(100, 20);
            this.tuser.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "username";
            // 
            // btn_fill
            // 
            this.btn_fill.Location = new System.Drawing.Point(180, 24);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(75, 23);
            this.btn_fill.TabIndex = 1;
            this.btn_fill.Text = "Fill";
            this.btn_fill.UseVisualStyleBackColor = true;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // cmb_per
            // 
            this.cmb_per.FormattingEnabled = true;
            this.cmb_per.Location = new System.Drawing.Point(6, 26);
            this.cmb_per.Name = "cmb_per";
            this.cmb_per.Size = new System.Drawing.Size(147, 21);
            this.cmb_per.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(180, 185);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 14;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(519, 238);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "Form1";
            this.Text = "ACCESS WinFORM CRUD";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_crt;
        private System.Windows.Forms.TextBox txbemail;
        private System.Windows.Forms.TextBox txbpass;
        private System.Windows.Forms.TextBox txbuser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_upd;
        private System.Windows.Forms.TextBox temail;
        private System.Windows.Forms.TextBox tpass;
        private System.Windows.Forms.TextBox tuser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.ComboBox cmb_per;
        private System.Windows.Forms.Button btn_Close;
    }
}

