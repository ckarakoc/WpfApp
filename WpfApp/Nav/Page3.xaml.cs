using System.Windows;
using System.Windows.Controls;

namespace WpfApp.Nav;

public partial class Page3 : Page
{
    public delegate void OnGoToPage1ButtonClick(object sender, RoutedEventArgs e);

    public event OnGoToPage1ButtonClick GoToPage1ButtonClick;

    public Page3()
    {
        InitializeComponent();
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        GoToPage1ButtonClick(sender, e);
    }
}