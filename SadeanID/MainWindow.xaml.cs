using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SadeanID;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
        public MainWindow()
    {
        InitializeComponent();
    }

        private void GroupRightsButton_Click(object sender, RoutedEventArgs e)
    {
        var window = new GroupRightsWindow { Owner = this };
        window.ShowDialog();
    }

    private void MenuExpander_Expanded(object sender, RoutedEventArgs e)
    {
        if (sender is not Expander selected || selected.Parent is not Panel menuPanel)
            return;

        foreach (var expander in menuPanel.Children.OfType<Expander>())
        {
            if (!ReferenceEquals(expander, selected))
                expander.IsExpanded = false;
        }
    }
}