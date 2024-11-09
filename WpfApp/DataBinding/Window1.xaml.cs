using System.Collections.ObjectModel;
using System.Windows;

namespace WpfApp.DataBinding;

public partial class Window1 : Window
{
    public ObservableCollection<int> AvailableNumbers { get; set; }
    int counter = 0;

    public Window1()
    {
        AvailableNumbers = [];
        for (var i = 0; i < 10; i++)
        {
            AvailableNumbers.Add(counter++);
        }

        InitializeComponent();
        DataContext = this;
    }

    private void AddNumber(object sender, RoutedEventArgs e)
    {
        AvailableNumbers.Add(counter++);
        Console.WriteLine(counter);
    }

    private void DeleteNumber(object sender, RoutedEventArgs e)
    {
        if (AvailableNumbers.Count > 0)
        {
            AvailableNumbers.RemoveAt(AvailableNumbers.Count - 1);
            counter--;
        }
        Console.WriteLine(counter);
    }
}