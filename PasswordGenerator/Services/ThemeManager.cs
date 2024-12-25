using System.Drawing;
using System.Windows.Forms;

namespace PasswordGenerator.Services
{
    public class ThemeManager : IThemeManager
    {
        private readonly Color _lightBackColor = Color.White;
        private readonly Color _lightForeColor = Color.Black;
        private readonly Color _darkBackColor = Color.FromArgb(45, 45, 48);
        private readonly Color _darkForeColor = Color.White;

        public void ApplyTheme(Form form, bool isDarkTheme)
        {
            Color backColor = isDarkTheme ? _darkBackColor : _lightBackColor;
            Color foreColor = isDarkTheme ? _darkForeColor : _lightForeColor;

            ApplyThemeToControl(form, backColor, foreColor);
        }

        private void ApplyThemeToControl(Control control, Color backColor, Color foreColor)
        {
            control.BackColor = backColor;
            control.ForeColor = foreColor;

            foreach (Control child in control.Controls)
            {
                ApplyThemeToControl(child, backColor, foreColor);
            }
        }
    }
}