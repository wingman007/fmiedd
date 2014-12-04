namespace CRUD_Project.Views
{
    partial class EditMovies
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
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textBoxDescr = new MetroFramework.Controls.MetroTextBox();
            this.dateTimePickerYear = new MetroFramework.Controls.MetroDateTime();
            this.textBoxCountry = new MetroFramework.Controls.MetroTextBox();
            this.textBoxCast = new MetroFramework.Controls.MetroTextBox();
            this.textBoxDirector = new MetroFramework.Controls.MetroTextBox();
            this.comboBoxCategory = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.textBoxTitle = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.textBoxDescr);
            this.groupBox1.Controls.Add(this.dateTimePickerYear);
            this.groupBox1.Controls.Add(this.textBoxCountry);
            this.groupBox1.Controls.Add(this.textBoxCast);
            this.groupBox1.Controls.Add(this.textBoxDirector);
            this.groupBox1.Controls.Add(this.comboBoxCategory);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.textBoxTitle);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 507);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit...";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(35, 277);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(77, 19);
            this.metroLabel7.TabIndex = 55;
            this.metroLabel7.Text = "Description:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(49, 229);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(38, 19);
            this.metroLabel6.TabIndex = 54;
            this.metroLabel6.Text = "Year:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(28, 188);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(59, 19);
            this.metroLabel5.TabIndex = 53;
            this.metroLabel5.Text = "Country:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(50, 151);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(37, 19);
            this.metroLabel4.TabIndex = 52;
            this.metroLabel4.Text = "Cast:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(30, 115);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(60, 19);
            this.metroLabel3.TabIndex = 51;
            this.metroLabel3.Text = "Director:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 77);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 50;
            this.metroLabel2.Text = "Category:";
            // 
            // textBoxDescr
            // 
            this.textBoxDescr.Lines = new string[0];
            this.textBoxDescr.Location = new System.Drawing.Point(34, 306);
            this.textBoxDescr.MaxLength = 32767;
            this.textBoxDescr.Multiline = true;
            this.textBoxDescr.Name = "textBoxDescr";
            this.textBoxDescr.PasswordChar = '\0';
            this.textBoxDescr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxDescr.SelectedText = "";
            this.textBoxDescr.Size = new System.Drawing.Size(348, 174);
            this.textBoxDescr.TabIndex = 49;
            this.textBoxDescr.UseSelectable = true;
            // 
            // dateTimePickerYear
            // 
            this.dateTimePickerYear.CustomFormat = "yyyy";
            this.dateTimePickerYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerYear.Location = new System.Drawing.Point(105, 225);
            this.dateTimePickerYear.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimePickerYear.Name = "dateTimePickerYear";
            this.dateTimePickerYear.Size = new System.Drawing.Size(121, 29);
            this.dateTimePickerYear.TabIndex = 48;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Lines = new string[0];
            this.textBoxCountry.Location = new System.Drawing.Point(105, 187);
            this.textBoxCountry.MaxLength = 32767;
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.PasswordChar = '\0';
            this.textBoxCountry.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxCountry.SelectedText = "";
            this.textBoxCountry.Size = new System.Drawing.Size(121, 23);
            this.textBoxCountry.TabIndex = 47;
            this.textBoxCountry.UseSelectable = true;
            // 
            // textBoxCast
            // 
            this.textBoxCast.Lines = new string[0];
            this.textBoxCast.Location = new System.Drawing.Point(105, 150);
            this.textBoxCast.MaxLength = 32767;
            this.textBoxCast.Name = "textBoxCast";
            this.textBoxCast.PasswordChar = '\0';
            this.textBoxCast.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxCast.SelectedText = "";
            this.textBoxCast.Size = new System.Drawing.Size(277, 23);
            this.textBoxCast.TabIndex = 46;
            this.textBoxCast.UseSelectable = true;
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Lines = new string[0];
            this.textBoxDirector.Location = new System.Drawing.Point(105, 114);
            this.textBoxDirector.MaxLength = 32767;
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.PasswordChar = '\0';
            this.textBoxDirector.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxDirector.SelectedText = "";
            this.textBoxDirector.Size = new System.Drawing.Size(121, 23);
            this.textBoxDirector.TabIndex = 45;
            this.textBoxDirector.UseSelectable = true;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.ItemHeight = 23;
            this.comboBoxCategory.Location = new System.Drawing.Point(105, 73);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 29);
            this.comboBoxCategory.TabIndex = 43;
            this.comboBoxCategory.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(54, 41);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 41;
            this.metroLabel1.Text = "Title:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Lines = new string[0];
            this.textBoxTitle.Location = new System.Drawing.Point(105, 39);
            this.textBoxTitle.MaxLength = 32767;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.PasswordChar = '\0';
            this.textBoxTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxTitle.SelectedText = "";
            this.textBoxTitle.Size = new System.Drawing.Size(277, 23);
            this.textBoxTitle.TabIndex = 40;
            this.textBoxTitle.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton1.Location = new System.Drawing.Point(247, 598);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 21;
            this.metroButton1.Text = "Save";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton2.Location = new System.Drawing.Point(352, 598);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 22;
            this.metroButton2.Text = "Cancel";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // EditMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 641);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditMovies";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Edit Movie";
            this.Load += new System.EventHandler(this.EditMovies_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox textBoxDescr;
        private MetroFramework.Controls.MetroDateTime dateTimePickerYear;
        private MetroFramework.Controls.MetroTextBox textBoxCountry;
        private MetroFramework.Controls.MetroTextBox textBoxCast;
        private MetroFramework.Controls.MetroTextBox textBoxDirector;
        private MetroFramework.Controls.MetroComboBox comboBoxCategory;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox textBoxTitle;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}