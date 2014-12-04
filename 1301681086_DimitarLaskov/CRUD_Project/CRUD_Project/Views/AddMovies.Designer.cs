namespace CRUD_Project.Views
{
    partial class AddMovies
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDescr = new MetroFramework.Controls.MetroTextBox();
            this.dateTimePickerYear = new MetroFramework.Controls.MetroDateTime();
            this.textBoxCountry = new MetroFramework.Controls.MetroTextBox();
            this.textBoxCast = new MetroFramework.Controls.MetroTextBox();
            this.textBoxDirector = new MetroFramework.Controls.MetroTextBox();
            this.textBoxNewCat = new MetroFramework.Controls.MetroTextBox();
            this.comboBoxCategory = new MetroFramework.Controls.MetroComboBox();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.textBoxTitle = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.groupBox1.Controls.Add(this.textBoxNewCat);
            this.groupBox1.Controls.Add(this.comboBoxCategory);
            this.groupBox1.Controls.Add(this.metroCheckBox1);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.textBoxTitle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 512);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fill the required fields";
            // 
            // textBoxDescr
            // 
            this.textBoxDescr.Lines = new string[0];
            this.textBoxDescr.Location = new System.Drawing.Point(32, 311);
            this.textBoxDescr.MaxLength = 32767;
            this.textBoxDescr.Multiline = true;
            this.textBoxDescr.Name = "textBoxDescr";
            this.textBoxDescr.PasswordChar = '\0';
            this.textBoxDescr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxDescr.SelectedText = "";
            this.textBoxDescr.Size = new System.Drawing.Size(348, 174);
            this.textBoxDescr.TabIndex = 32;
            this.textBoxDescr.UseSelectable = true;
            // 
            // dateTimePickerYear
            // 
            this.dateTimePickerYear.CustomFormat = "yyyy";
            this.dateTimePickerYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerYear.Location = new System.Drawing.Point(103, 230);
            this.dateTimePickerYear.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimePickerYear.Name = "dateTimePickerYear";
            this.dateTimePickerYear.Size = new System.Drawing.Size(121, 29);
            this.dateTimePickerYear.TabIndex = 31;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Lines = new string[0];
            this.textBoxCountry.Location = new System.Drawing.Point(103, 192);
            this.textBoxCountry.MaxLength = 32767;
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.PasswordChar = '\0';
            this.textBoxCountry.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxCountry.SelectedText = "";
            this.textBoxCountry.Size = new System.Drawing.Size(121, 23);
            this.textBoxCountry.TabIndex = 30;
            this.textBoxCountry.UseSelectable = true;
            // 
            // textBoxCast
            // 
            this.textBoxCast.Lines = new string[0];
            this.textBoxCast.Location = new System.Drawing.Point(103, 155);
            this.textBoxCast.MaxLength = 32767;
            this.textBoxCast.Name = "textBoxCast";
            this.textBoxCast.PasswordChar = '\0';
            this.textBoxCast.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxCast.SelectedText = "";
            this.textBoxCast.Size = new System.Drawing.Size(277, 23);
            this.textBoxCast.TabIndex = 29;
            this.textBoxCast.UseSelectable = true;
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Lines = new string[0];
            this.textBoxDirector.Location = new System.Drawing.Point(103, 119);
            this.textBoxDirector.MaxLength = 32767;
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.PasswordChar = '\0';
            this.textBoxDirector.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxDirector.SelectedText = "";
            this.textBoxDirector.Size = new System.Drawing.Size(121, 23);
            this.textBoxDirector.TabIndex = 28;
            this.textBoxDirector.UseSelectable = true;
            // 
            // textBoxNewCat
            // 
            this.textBoxNewCat.Lines = new string[] {
        "add new category"};
            this.textBoxNewCat.Location = new System.Drawing.Point(254, 80);
            this.textBoxNewCat.MaxLength = 32767;
            this.textBoxNewCat.Name = "textBoxNewCat";
            this.textBoxNewCat.PasswordChar = '\0';
            this.textBoxNewCat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxNewCat.SelectedText = "";
            this.textBoxNewCat.Size = new System.Drawing.Size(126, 23);
            this.textBoxNewCat.TabIndex = 27;
            this.textBoxNewCat.Text = "add new category";
            this.textBoxNewCat.UseSelectable = true;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.ItemHeight = 23;
            this.comboBoxCategory.Location = new System.Drawing.Point(103, 78);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 29);
            this.comboBoxCategory.TabIndex = 26;
            this.comboBoxCategory.UseSelectable = true;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroCheckBox1.Location = new System.Drawing.Point(230, 87);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(26, 15);
            this.metroCheckBox1.TabIndex = 25;
            this.metroCheckBox1.Text = " ";
            this.metroCheckBox1.UseSelectable = true;
            this.metroCheckBox1.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(52, 46);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "Title:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Lines = new string[0];
            this.textBoxTitle.Location = new System.Drawing.Point(103, 44);
            this.textBoxTitle.MaxLength = 32767;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.PasswordChar = '\0';
            this.textBoxTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxTitle.SelectedText = "";
            this.textBoxTitle.Size = new System.Drawing.Size(277, 23);
            this.textBoxTitle.TabIndex = 23;
            this.textBoxTitle.UseSelectable = true;
            this.textBoxTitle.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "or";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton1.Location = new System.Drawing.Point(12, 592);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(88, 30);
            this.metroButton1.TabIndex = 21;
            this.metroButton1.Text = "Save";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton2.Location = new System.Drawing.Point(132, 592);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(88, 30);
            this.metroButton2.TabIndex = 22;
            this.metroButton2.Text = "Clear";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton3.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton3.Location = new System.Drawing.Point(341, 592);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(88, 30);
            this.metroButton3.TabIndex = 23;
            this.metroButton3.Text = "Cancel";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(21, 82);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 33;
            this.metroLabel2.Text = "Category:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(28, 120);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(60, 19);
            this.metroLabel3.TabIndex = 34;
            this.metroLabel3.Text = "Director:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(48, 156);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(37, 19);
            this.metroLabel4.TabIndex = 35;
            this.metroLabel4.Text = "Cast:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(26, 193);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(59, 19);
            this.metroLabel5.TabIndex = 36;
            this.metroLabel5.Text = "Country:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(47, 234);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(38, 19);
            this.metroLabel6.TabIndex = 37;
            this.metroLabel6.Text = "Year:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(33, 282);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(77, 19);
            this.metroLabel7.TabIndex = 38;
            this.metroLabel7.Text = "Description:";
            // 
            // AddMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 642);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddMovies";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Add New Movie";
            this.Load += new System.EventHandler(this.AddMovies_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroTextBox textBoxTitle;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox comboBoxCategory;
        private MetroFramework.Controls.MetroDateTime dateTimePickerYear;
        private MetroFramework.Controls.MetroTextBox textBoxCountry;
        private MetroFramework.Controls.MetroTextBox textBoxCast;
        private MetroFramework.Controls.MetroTextBox textBoxDirector;
        private MetroFramework.Controls.MetroTextBox textBoxNewCat;
        private MetroFramework.Controls.MetroTextBox textBoxDescr;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}