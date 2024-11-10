using System.Windows;
using System.Windows.Controls;

namespace WpfApp.Nav;

public partial class Page2 : Page
{
    public delegate void OnGoToPage1ButtonClick(object sender, RoutedEventArgs e);
    public delegate void OnGoToPage3ButtonClick(object sender, RoutedEventArgs e);

    public event OnGoToPage1ButtonClick GoToPage1ButtonClick;
    public event OnGoToPage3ButtonClick GoToPage3ButtonClick;


    public Page2()
    {
        InitializeComponent();
    }

    private void ButtonBase_OnClick1(object sender, RoutedEventArgs e)
    {
        GoToPage1ButtonClick(sender, e);
    }

    private void ButtonBase_OnClick3(object sender, RoutedEventArgs e)
    {
        GoToPage3ButtonClick(sender, e);
    }
}