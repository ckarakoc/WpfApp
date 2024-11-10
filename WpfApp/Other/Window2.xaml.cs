using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace WpfApp.Other;

public partial class Window2 : Window
{
    public Window2()
    {
        InitializeComponent();
    }

    private void MainGrid_OnLoaded(object sender, RoutedEventArgs e)
    {
        var fadeIn = new DoubleAnimation()
        {
            Duration = TimeSpan.FromSeconds(1.0d),
            From = 0.0d,
            To = 1.0d
        };

        MainGrid.BeginAnimation(OpacityProperty, fadeIn);
    }

    private void MainGrid_OnMouseEnter(object sender, MouseEventArgs e)
    {
        MainGrid.BeginAnimation(OpacityProperty, new DoubleAnimation()
        {
            Duration = TimeSpan.FromSeconds(1.0d),
            From = 1.0d,
            To = 0.0d
        });
    }

    private void MainGrid_OnMouseLeave(object sender, MouseEventArgs e)
    {
        MainGrid.BeginAnimation(OpacityProperty, new DoubleAnimation()
        {
            Duration = TimeSpan.FromSeconds(1.0d),
            From = 0.0d,
            To = 1.0d
        });
    }
}