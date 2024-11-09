using System.Windows;
using System.Windows.Controls;

namespace WpfApp;

public partial class Window8 : Window
{
    public Window8()
    {
        InitializeComponent();
        myTextBlock.Text = myCalendar.SelectedDate.ToString();
    }

    private void MyCalendar_OnSelectedDatesChanged(object? sender, SelectionChangedEventArgs e)
    {
        if (myTextBlock != null)
        {
            myTextBlock.Text = myCalendar.SelectedDate.ToString();
        }
    }
}