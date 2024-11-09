using System.Windows;

namespace WpfApp.Menu;

public partial class Window3 : Window
{
    public Window3()
    {
        InitializeComponent();
    }

    private void MiBold_OnClick(object sender, RoutedEventArgs e)
    {
        myTB.FontWeight = myTB.FontWeight == FontWeights.Bold ? FontWeights.Normal : FontWeights.Bold;
    }

    private void MiItalic_OnClick(object sender, RoutedEventArgs e)
    {
        myTB.FontStyle = myTB.FontStyle == FontStyles.Italic ? FontStyles.Normal : FontStyles.Italic;
    }

    private void MiUnderline_OnClick(object sender, RoutedEventArgs e)
    {
        myTB.TextDecorations = myTB.TextDecorations == TextDecorations.Underline ? null : TextDecorations.Underline;
    }
}