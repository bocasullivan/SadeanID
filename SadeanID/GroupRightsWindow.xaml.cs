using System.Windows;

namespace SadeanID;

public partial class GroupRightsWindow : Window
{
    public GroupRightsWindow() => InitializeComponent();

    private void SaveButton_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"Hak akses role {RoleComboBox.Text} berhasil disimpan (demo).", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information);
    }
}
