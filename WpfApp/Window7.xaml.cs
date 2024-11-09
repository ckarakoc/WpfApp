using System.Windows;

namespace WpfApp;

public partial class Window7 : Window
{
    public Window7()
    {
        InitializeComponent();
    }

    private void MySlider_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
        if (TxtBlock != null && mySlider.Value > 0d)
        {
            TxtBlock.Text = "Slider value is " + mySlider.Value.ToString();
            TxtBlock.FontSize = mySlider.Value;
        }
    }
}