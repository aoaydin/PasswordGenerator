namespace PasswordGenerator
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblLength = new System.Windows.Forms.Label();
            this.numPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.chkUppercase = new System.Windows.Forms.CheckBox();
            this.chkLowercase = new System.Windows.Forms.CheckBox();
            this.chkNumbers = new System.Windows.Forms.CheckBox();
            this.chkSpecial = new System.Windows.Forms.CheckBox();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.comboTheme = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.progressStrength = new System.Windows.Forms.ProgressBar();
            this.lblStrength = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPasswordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblLength, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numPasswordLength, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkUppercase, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkLowercase, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkNumbers, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.chkSpecial, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnGeneratePassword, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.comboTheme, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnCopy, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.progressStrength, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblStrength, 1, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(512, 567);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLength.Location = new System.Drawing.Point(17, 12);
            this.lblLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(235, 65);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Şifre Uzunluğu:";
            this.lblLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numPasswordLength
            // 
            this.numPasswordLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPasswordLength.Location = new System.Drawing.Point(260, 16);
            this.numPasswordLength.Margin = new System.Windows.Forms.Padding(4);
            this.numPasswordLength.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numPasswordLength.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numPasswordLength.Name = "numPasswordLength";
            this.numPasswordLength.Size = new System.Drawing.Size(235, 22);
            this.numPasswordLength.TabIndex = 1;
            this.numPasswordLength.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // chkUppercase
            // 
            this.chkUppercase.AutoSize = true;
            this.chkUppercase.Checked = true;
            this.chkUppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUppercase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkUppercase.Location = new System.Drawing.Point(17, 81);
            this.chkUppercase.Margin = new System.Windows.Forms.Padding(4);
            this.chkUppercase.Name = "chkUppercase";
            this.chkUppercase.Size = new System.Drawing.Size(235, 57);
            this.chkUppercase.TabIndex = 2;
            this.chkUppercase.Text = "Büyük Harfler (A-Z)";
            // 
            // chkLowercase
            // 
            this.chkLowercase.AutoSize = true;
            this.chkLowercase.Checked = true;
            this.chkLowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLowercase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkLowercase.Location = new System.Drawing.Point(17, 146);
            this.chkLowercase.Margin = new System.Windows.Forms.Padding(4);
            this.chkLowercase.Name = "chkLowercase";
            this.chkLowercase.Size = new System.Drawing.Size(235, 57);
            this.chkLowercase.TabIndex = 3;
            this.chkLowercase.Text = "Küçük Harfler (a-z)";
            // 
            // chkNumbers
            // 
            this.chkNumbers.AutoSize = true;
            this.chkNumbers.Checked = true;
            this.chkNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNumbers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkNumbers.Location = new System.Drawing.Point(17, 211);
            this.chkNumbers.Margin = new System.Windows.Forms.Padding(4);
            this.chkNumbers.Name = "chkNumbers";
            this.chkNumbers.Size = new System.Drawing.Size(235, 57);
            this.chkNumbers.TabIndex = 4;
            this.chkNumbers.Text = "Rakamlar (0-9)";
            // 
            // chkSpecial
            // 
            this.chkSpecial.AutoSize = true;
            this.chkSpecial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSpecial.Location = new System.Drawing.Point(17, 276);
            this.chkSpecial.Margin = new System.Windows.Forms.Padding(4);
            this.chkSpecial.Name = "chkSpecial";
            this.chkSpecial.Size = new System.Drawing.Size(235, 57);
            this.chkSpecial.TabIndex = 5;
            this.chkSpecial.Text = "Özel Karakterler (!@#$)";
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGeneratePassword.Location = new System.Drawing.Point(17, 341);
            this.btnGeneratePassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(235, 57);
            this.btnGeneratePassword.TabIndex = 6;
            this.btnGeneratePassword.Text = "Şifre Oluştur";
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // comboTheme
            // 
            this.comboTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTheme.FormattingEnabled = true;
            this.comboTheme.Items.AddRange(new object[] {
            "Açık Tema",
            "Koyu Tema"});
            this.comboTheme.Location = new System.Drawing.Point(260, 341);
            this.comboTheme.Margin = new System.Windows.Forms.Padding(4);
            this.comboTheme.Name = "comboTheme";
            this.comboTheme.Size = new System.Drawing.Size(235, 24);
            this.comboTheme.TabIndex = 11;
            this.comboTheme.SelectedIndexChanged += new System.EventHandler(this.comboTheme_SelectedIndexChanged);
            // 
            // txtPassword
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtPassword, 2);
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Location = new System.Drawing.Point(17, 406);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(478, 22);
            this.txtPassword.TabIndex = 7;
            // 
            // btnCopy
            // 
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopy.Location = new System.Drawing.Point(17, 471);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(235, 57);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "Panoya Kopyala";
            this.btnCopy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCopy_Click);
            // 
            // progressStrength
            // 
            this.progressStrength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressStrength.Location = new System.Drawing.Point(260, 471);
            this.progressStrength.Margin = new System.Windows.Forms.Padding(4);
            this.progressStrength.Name = "progressStrength";
            this.progressStrength.Size = new System.Drawing.Size(235, 57);
            this.progressStrength.TabIndex = 9;
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStrength.Location = new System.Drawing.Point(17, 532);
            this.lblStrength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(235, 23);
            this.lblStrength.TabIndex = 10;
            this.lblStrength.Text = "Şifre Gücü: 0%";
            this.lblStrength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 567);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(527, 605);
            this.Name = "MainForm";
            this.Text = "Şifre Oluşturucu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPasswordLength)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.NumericUpDown numPasswordLength;
        private System.Windows.Forms.CheckBox chkUppercase;
        private System.Windows.Forms.CheckBox chkLowercase;
        private System.Windows.Forms.CheckBox chkNumbers;
        private System.Windows.Forms.CheckBox chkSpecial;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ProgressBar progressStrength;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.ComboBox comboTheme;
    }
}