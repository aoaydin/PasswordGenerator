# PasswordGenerator

This simple C# Windows Forms application generates strong, customizable passwords.  Users can specify password length, and choose to include uppercase letters, lowercase letters, numbers, and special characters.  The application also provides a password strength meter and allows users to copy the generated password to their clipboard.  A simple theme switching mechanism is included for visual customization.  The project utilizes dependency injection for better maintainability and testability.


This improved version includes:

* Clearer comments:  Explaining the purpose of each code section.
* Improved variable names: More descriptive names for better readability.
* Default value for `chkSpecial`: Added a default value to the `chkSpecial` checkbox.
* English error messages: Changed Turkish error messages to English for better internationalization.
* More concise code: Minor improvements for better readability.
* GitHub Description: A comprehensive description suitable for a GitHub repository.  Remember to add a license file to your repository.

Remember to replace placeholders like "dark theme" with the actual theme names used in your application.  Also, ensure that your `PasswordGenerator.Models` and `PasswordGenerator.Services` namespaces contain the necessary classes (`PasswordOptions`, `IPasswordGenerator`, `PasswordGeneratorService`, `IThemeManager`, `ThemeManager`).

# Şifre Üretici Uygulaması

Bu uygulama, özelleştirilebilir seçeneklerle güçlü şifreler oluşturmanıza olanak tanır.  Kullanıcılar şifre uzunluğunu, büyük/küçük harf, rakam ve özel karakter kullanımını belirleyebilirler.  Oluşturulan şifrenin gücü bir ilerleme çubuğu ile gösterilir ve şifre panoya kopyalanabilir.  Uygulama ayrıca tema değiştirme özelliğine sahiptir.

Özellikler:

* Özelleştirilebilir Şifre Oluşturma: Şifre uzunluğu, büyük/küçük harf, rakam ve özel karakter kullanımını kontrol edebilirsiniz.
* Şifre Gücü Gösterimi: Oluşturulan şifrenin gücü bir ilerleme çubuğu ile gösterilir.
* Panoya Kopyalama: Oluşturulan şifre tek bir tıklamayla panoya kopyalanabilir.
* Tema Değiştirme: Uygulamanın temasını değiştirebilirsiniz. (Açık/Karanlık)


Kullanım:

1. Uygulamayı çalıştırın
