using System;
using System.Windows.Forms;
using PasswordGenerator.Models;
using PasswordGenerator.Services;


namespace PasswordGenerator
{
    public partial class MainForm : Form
    {
        private readonly IPasswordGenerator _passwordGenerator;
        private readonly IThemeManager _themeManager;

        public MainForm()
        {
            InitializeComponent();
            _passwordGenerator = new PasswordGeneratorService();
            _themeManager = new ThemeManager();
            InitializeControls();
        }

        private void InitializeControls()
        {
            numPasswordLength.Minimum = 8;
            numPasswordLength.Maximum = 20;
            numPasswordLength.Value = 12;

            chkUppercase.Checked = true;
            chkLowercase.Checked = true;
            chkNumbers.Checked = true;

          
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            try
            {
                var options = new PasswordOptions
                {
                    Length = (int)numPasswordLength.Value,
                    IncludeUppercase = chkUppercase.Checked,
                    IncludeLowercase = chkLowercase.Checked,
                    IncludeNumbers = chkNumbers.Checked,
                    IncludeSpecial = chkSpecial.Checked
                };

                string password = _passwordGenerator.GeneratePassword(options);
                txtPassword.Text = password;

                UpdatePasswordStrength(password);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePasswordStrength(string password)
        {
            int strength = _passwordGenerator.CalculatePasswordStrength(password);
            progressStrength.Value = strength;
            lblStrength.Text = $"Şifre Gücü: {strength}%";
        }

       

        private void comboTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            _themeManager.ApplyTheme(this, comboTheme.SelectedIndex == 1);
        }

        private void btnCopy_Click(object sender, MouseEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                Clipboard.SetText(txtPassword.Text);
                MessageBox.Show("Şifre panoya kopyalandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}