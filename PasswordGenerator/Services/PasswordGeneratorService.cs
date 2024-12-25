using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using PasswordGenerator.Models;

namespace PasswordGenerator.Services
{
    public class PasswordGeneratorService : IPasswordGenerator
    {
        private readonly RNGCryptoServiceProvider _rng;

        public PasswordGeneratorService()
        {
            _rng = new RNGCryptoServiceProvider();
        }

        public string GeneratePassword(Models.PasswordOptions options)  // Tam namespace yolu ekleyin
        {
            const string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowercase = "abcdefghijklmnopqrstuvwxyz";
            const string numbers = "0123456789";
            const string special = "!@#$%^&*()_+-=[]{}|;:,.<>?";

            var charSet = new StringBuilder();
            var password = new StringBuilder();

            if (options.IncludeUppercase) charSet.Append(uppercase);
            if (options.IncludeLowercase) charSet.Append(lowercase);
            if (options.IncludeNumbers) charSet.Append(numbers);
            if (options.IncludeSpecial) charSet.Append(special);

            if (charSet.Length == 0)
                throw new ArgumentException("En az bir karakter seti seçilmelidir.");

            for (int i = 0; i < options.Length; i++)
            {
                byte[] randomNumber = new byte[1];
                _rng.GetBytes(randomNumber);
                password.Append(charSet[randomNumber[0] % charSet.Length]);
            }

            return password.ToString();
        }

        public int CalculatePasswordStrength(string password)
        {
            int score = 0;
            if (password.Length >= 8) score += 20;
            if (password.Any(char.IsUpper)) score += 20;
            if (password.Any(char.IsLower)) score += 20;
            if (password.Any(char.IsDigit)) score += 20;
            if (password.Any(c => !char.IsLetterOrDigit(c))) score += 20;
            return score;
        }
    }
}