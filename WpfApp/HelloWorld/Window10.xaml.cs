using System.Windows;

namespace WpfApp;

public partial class Window10 : Window
{
    public Window10()
    {
        InitializeComponent();
    }

    private void Expander_OnExpanded(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Expander was clicked");
    }
}