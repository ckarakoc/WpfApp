using System.Windows;
using System.Windows.Controls;

namespace WpfApp.Menu;

public partial class Window2 : Window
{
    public Window2()
    {
        InitializeComponent();
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        MyTextBox.Text = string.Empty;
    }

    private void Selector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var box = (ComboBox) sender;
        var boxItem = (ComboBoxItem) box.SelectedItem;
        var boxValue = (string) boxItem.Content;

        if (int.TryParse(boxValue, out var temp))
        {
            if (MyTextBox != null)
            {
                MyTextBox.FontSize = temp;
            }
        }
    }
}