using System.Windows.Forms;

namespace PasswordGenerator.Services
{
    public interface IThemeManager
    {
        void ApplyTheme(Form form, bool isDarkTheme);
    }
}