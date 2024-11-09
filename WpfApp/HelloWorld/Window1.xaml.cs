using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Navigation;

namespace WpfApp;

public partial class Window1 : Window
{
    public Window1()
    {
        InitializeComponent();
        MyTextBlock.Text = "Hello from the cs Side!";
        MyTextBlock.Foreground = Brushes.Blue;

        TextBlock myTb = new TextBlock();
        myTb.Text = "Hello WORLD from the cs Side!";
        myTb.Inlines.Add(" Added through Inlines");
        myTb.Inlines.Add(new Run
        {
            Text = " Added through Inlines",
            Foreground = Brushes.Red,
            TextDecorations = TextDecorations.Underline
        });
        MyStackPanel.Children.Add(myTb);
    }

    private void Hyperlink_OnRequestNavigate(object sender, RequestNavigateEventArgs e)
    {
        Process.Start(new ProcessStartInfo
        {
            FileName = e.Uri.AbsoluteUri,
            UseShellExecute = true
        });
    }
}