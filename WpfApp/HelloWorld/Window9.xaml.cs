using System.Windows;
using System.Windows.Controls;

namespace WpfApp;

public partial class Window9 : Window
{
    public Window9()
    {
        InitializeComponent();
    }

    private void DatePicker_OnSelectedDateChanged(object? sender, SelectionChangedEventArgs e)
    {
        var date = (sender as DatePicker);
        if (date != null)
        {
            MessageBox.Show("Date has been changed to " + date.SelectedDate.ToString());
        }
    }
}