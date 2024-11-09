using System.Windows;
using System.Windows.Media;

namespace WpfApp;

public partial class Window5 : Window
{
    public Window5()
    {
        InitializeComponent();
    }

    private void ToggleButton_OnChecked(object sender, RoutedEventArgs e)
    {
        lbMe.Background = Brushes.Aqua;
    }

    private void ToggleButton_OnUnchecked(object sender, RoutedEventArgs e)
    {
        lbMe.Background = Brushes.White;
    }
}