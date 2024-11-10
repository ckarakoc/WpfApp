using System.Windows;

namespace WpfApp.Nav;

public partial class Window1 : Window
{
    public Page1 firstPage;
    public Page2 secondPage;
    public Page3 thirdPage;

    public Window1()
    {
        InitializeComponent();
        firstPage = new Page1();
        secondPage = new Page2();
        thirdPage = new Page3();

        thirdPage.GoToPage1ButtonClick += ButtonBase_OnClick1;
        secondPage.GoToPage1ButtonClick += ButtonBase_OnClick1;
        secondPage.GoToPage3ButtonClick += ButtonBase_OnClick3;
    }

    private void ButtonBase_OnClick1(object sender, RoutedEventArgs e)
    {
        MainFrame.Content = firstPage;
    }

    private void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
    {
        MainFrame.Content = secondPage;
    }
    
    private void ButtonBase_OnClick3(object sender, RoutedEventArgs e)
    {
        MainFrame.Content = thirdPage;
    }

    private void BackButton_OnClick(object sender, RoutedEventArgs e)
    {
        if (MainFrame.NavigationService.CanGoBack)
        {
            MainFrame.NavigationService.GoBack();
        }
    }

    private void ForwardButton_OnClick(object sender, RoutedEventArgs e)
    {
        if (MainFrame.NavigationService.CanGoForward)
        {
            MainFrame.NavigationService.GoForward();
        }
    }

   
}