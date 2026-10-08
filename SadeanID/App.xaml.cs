using System.Configuration;
using System.Data;
using System.Windows;

namespace SadeanID;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        var loginWindow = new LoginWindow();
        MainWindow = loginWindow;
        loginWindow.Show();
    }
}

