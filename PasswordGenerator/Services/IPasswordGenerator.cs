using PasswordGenerator.Models;

namespace PasswordGenerator.Services
{
    public interface IPasswordGenerator
    {
        string GeneratePassword(Models.PasswordOptions options);  // Tam namespace yolu ekleyin
        int CalculatePasswordStrength(string password);
    }
}