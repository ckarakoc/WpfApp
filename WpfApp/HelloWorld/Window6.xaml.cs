using System.Windows;
using System.Windows.Media;

namespace WpfApp;

public partial class Window6 : Window
{
    public Window6()
    {
        InitializeComponent();
    }

    private void CbCheese_OnChecked(object sender, RoutedEventArgs e)
    {
        cbCheese.Background = Brushes.Green;
    }

    private void CbCheese_OnUnchecked(object sender, RoutedEventArgs e)
    {
        cbCheese.Background = Brushes.Black;
    }

    private void CbParent_Check(object sender, RoutedEventArgs e)
    {
        bool newValue = cbParent.IsChecked == true;
        cbCheese.IsChecked = newValue;
        cbTuna.IsChecked = newValue;
        cbHaram.IsChecked = newValue;
        cbPepp.IsChecked = newValue;
    }
}