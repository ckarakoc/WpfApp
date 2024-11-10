using System.Windows;
using System.Windows.Controls;

namespace WpfApp.UserControls;

public partial class MyUC : UserControl
{
    public static readonly DependencyProperty AwesomenessProperty = DependencyProperty.Register(
        nameof(Awesomeness), typeof(int), typeof(MyUC), new PropertyMetadata(default(int)));

    public int Awesomeness
    {
        get => (int) GetValue(AwesomenessProperty);
        set => SetValue(AwesomenessProperty, value);
    }

    public MyUC()
    {
        InitializeComponent();
    }
}