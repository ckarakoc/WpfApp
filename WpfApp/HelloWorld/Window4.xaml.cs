using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfApp;

public partial class Window4 : Window
{
    public Window4()
    {
        InitializeComponent();
    }

    private void MyButton_OnClick(object sender, RoutedEventArgs e)
    {
        myLabel.Foreground = Brushes.Turquoise;
        myLabel.FontSize += 1;
    }

    private void MyButton_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
        myLabel.Background = Brushes.Chocolate;
    }

    private void MyButton_OnMouseEnter(object sender, MouseEventArgs e)
    {
        myLabel.Foreground = Brushes.White;
    }

    private void MyButton_OnMouseLeave(object sender, MouseEventArgs e)
    {
        myLabel.Foreground = Brushes.Black;
    }
}