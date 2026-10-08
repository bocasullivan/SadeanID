using System.Windows;

namespace SadeanID;

public partial class LoginWindow : Window
{
    public LoginWindow()
    {
        InitializeComponent();
        UsernameTextBox.Focus();
    }

    private void LoginButton_Click(object sender, RoutedEventArgs e)
    {
        if (UsernameTextBox.Text.Trim().Equals("admin", StringComparison.OrdinalIgnoreCase)
            && PasswordBox.Password == "admin")
        {
            var mainWindow = new MainWindow();
            Application.Current.MainWindow = mainWindow;
            mainWindow.Show();
            Close();
            return;
        }

        ErrorTextBlock.Text = "Username atau password salah.";
        PasswordBox.Clear();
        PasswordBox.Focus();
    }
}
