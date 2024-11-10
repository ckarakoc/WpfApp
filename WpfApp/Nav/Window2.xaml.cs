using System.Windows;

namespace WpfApp.Nav;

public partial class Window2 : Window
{
    public Window2()
    {
        InitializeComponent();
        ValueController.MinThresholdReached += ValueController_MinThresholdReached;
        ValueController.MaxThresholdReached += ValueController_MaxThresholdReached;
    }

    private void ValueController_MinThresholdReached(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Min Threshold Reached");
    }

    private void ValueController_MaxThresholdReached(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Max Threshold Reached");
    }
}