using System.Windows;
using System.Windows.Input;

namespace WpfApp.Other;

public partial class Window3 : Window
{
    public Window3()
    {
        InitializeComponent();
    }

    private void CommandBinding_OnExecuted(object sender, ExecutedRoutedEventArgs e)
    {
        this.Close();
        MessageBox.Show("Close command was invoked");
    }

    private void CommandBinding_OnCanExecute(object sender, CanExecuteRoutedEventArgs e)
    {
        e.CanExecute = true;
    }
}