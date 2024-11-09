using System.Windows;

namespace WpfApp.Menu;

public partial class Window1 : Window
{
    public Window1()
    {
        InitializeComponent();
    }

    private void MenuItem_OnClick(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("New File...");
    }
}