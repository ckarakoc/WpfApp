using System.Windows;
using System.Windows.Controls;

namespace WpfApp.Nav;

public partial class UserControl1 : UserControl
{
    public delegate void OnMinThresholdReached(object sender, RoutedEventArgs e);
    public event OnMinThresholdReached MinThresholdReached;
    
    public delegate void OnMaxThresholdReached(object sender, RoutedEventArgs e);
    public event OnMaxThresholdReached MaxThresholdReached;

    public UserControl1()
    {
        InitializeComponent();
    }

    private void MinButton_OnClick(object sender, RoutedEventArgs e)
    {
        ValueLabel.Text = (int.Parse(ValueLabel.Text) - 10).ToString();
    }

    private void PlusButton_OnClick(object sender, RoutedEventArgs e)
    {
        ValueLabel.Text = (int.Parse(ValueLabel.Text) + 10).ToString();
    }

    private void ValueLabel_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        var val = int.Parse((sender as TextBox).Text);
        if (val < 0)
        {
            (sender as TextBox).Text = "0";
            MinThresholdReached(sender, e);
        } else if (val > 100)
        {
            (sender as TextBox).Text = "100";
            MaxThresholdReached(sender, e);
        }
    }
}