using System.Windows;

namespace WpfApp.DependencyProperties;

public partial class Window1 : Window
{
    public Window1()
    {
        InitializeComponent();
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        MyUCinMain.Awesomeness += 1000;
    }
}