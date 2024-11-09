using System.Windows;

namespace WpfApp.Menu;

public partial class Window4 : Window
{
    public Window4()
    {
        InitializeComponent();
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        if (myPB.Value >= 100)
        {
            sbItem.Content = "Done";
        }
        else
        {
            myPB.Value += 10;
        }
    }
}