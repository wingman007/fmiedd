namespace AccessWinFormApplication___CRUD
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
            this.gbCreate = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tbE = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbUN = new System.Windows.Forms.TextBox();
            this.lblE = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUN = new System.Windows.Forms.Label();
            this.gbRUD = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserN = new System.Windows.Forms.Label();
            this.cmbCreated = new System.Windows.Forms.ComboBox();
            this.gbCreate.SuspendLayout();
            this.gbRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCreate
            // 
            this.gbCreate.Controls.Add(this.btnCreate);
            this.gbCreate.Controls.Add(this.tbE);
            this.gbCreate.Controls.Add(this.tbPass);
            this.gbCreate.Controls.Add(this.tbUN);
            this.gbCreate.Controls.Add(this.lblE);
            this.gbCreate.Controls.Add(this.lblPass);
            this.gbCreate.Controls.Add(this.lblUN);
            this.gbCreate.Location = new System.Drawing.Point(13, 13);
            this.gbCreate.Name = "gbCreate";
            this.gbCreate.Size = new System.Drawing.Size(652, 162);
            this.gbCreate.TabIndex = 0;
            this.gbCreate.TabStop = false;
            this.gbCreate.Text = "Create";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(393, 41);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(122, 43);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tbE
            // 
            this.tbE.Location = new System.Drawing.Point(161, 86);
            this.tbE.Name = "tbE";
            this.tbE.Size = new System.Drawing.Size(175, 20);
            this.tbE.TabIndex = 5;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(161, 54);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(175, 20);
            this.tbPass.TabIndex = 4;
            // 
            // tbUN
            // 
            this.tbUN.Location = new System.Drawing.Point(161, 24);
            this.tbUN.Name = "tbUN";
            this.tbUN.Size = new System.Drawing.Size(175, 20);
            this.tbUN.TabIndex = 3;
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Location = new System.Drawing.Point(72, 93);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(35, 13);
            this.lblE.TabIndex = 2;
            this.lblE.Text = "E-mail";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(72, 61);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(53, 13);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Password";
            // 
            // lblUN
            // 
            this.lblUN.AutoSize = true;
            this.lblUN.Location = new System.Drawing.Point(72, 31);
            this.lblUN.Name = "lblUN";
            this.lblUN.Size = new System.Drawing.Size(55, 13);
            this.lblUN.TabIndex = 0;
            this.lblUN.Text = "Username";
            // 
            // gbRUD
            // 
            this.gbRUD.Controls.Add(this.btnDelete);
            this.gbRUD.Controls.Add(this.btnFill);
            this.gbRUD.Controls.Add(this.btnUpdate);
            this.gbRUD.Controls.Add(this.tbEmail);
            this.gbRUD.Controls.Add(this.tbPassword);
            this.gbRUD.Controls.Add(this.tbUserName);
            this.gbRUD.Controls.Add(this.lblEmail);
            this.gbRUD.Controls.Add(this.lblPassword);
            this.gbRUD.Controls.Add(this.lblUserN);
            this.gbRUD.Controls.Add(this.cmbCreated);
            this.gbRUD.Location = new System.Drawing.Point(13, 202);
            this.gbRUD.Name = "gbRUD";
            this.gbRUD.Size = new System.Drawing.Size(652, 195);
            this.gbRUD.TabIndex = 1;
            this.gbRUD.TabStop = false;
            this.gbRUD.Text = "Retrieve, Update, Delete";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(52, 127);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(52, 70);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(130, 23);
            this.btnFill.TabIndex = 8;
            this.btnFill.Text = "Fill";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(406, 149);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 27);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(406, 96);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(161, 20);
            this.tbEmail.TabIndex = 6;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(406, 62);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(161, 20);
            this.tbPassword.TabIndex = 5;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(406, 28);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(161, 20);
            this.tbUserName.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(299, 104);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(299, 70);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // lblUserN
            // 
            this.lblUserN.AutoSize = true;
            this.lblUserN.Location = new System.Drawing.Point(299, 36);
            this.lblUserN.Name = "lblUserN";
            this.lblUserN.Size = new System.Drawing.Size(55, 13);
            this.lblUserN.TabIndex = 1;
            this.lblUserN.Text = "Username";
            // 
            // cmbCreated
            // 
            this.cmbCreated.FormattingEnabled = true;
            this.cmbCreated.Location = new System.Drawing.Point(24, 29);
            this.cmbCreated.Name = "cmbCreated";
            this.cmbCreated.Size = new System.Drawing.Size(185, 21);
            this.cmbCreated.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 437);
            this.Controls.Add(this.gbRUD);
            this.Controls.Add(this.gbCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCreate.ResumeLayout(false);
            this.gbCreate.PerformLayout();
            this.gbRUD.ResumeLayout(false);
            this.gbRUD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCreate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox tbE;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbUN;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUN;
        private System.Windows.Forms.GroupBox gbRUD;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserN;
        private System.Windows.Forms.ComboBox cmbCreated;
    }
}

