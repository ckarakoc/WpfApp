using System.Windows;

namespace WpfApp.Other;

public partial class Window4 : Window
{
    List<int> myList;
    List<int> defaultList;

    public Window4()
    {
        InitializeComponent();
        myList = [4, 5, 6, 3, 2, 1, 7, 8, 9];
        defaultList = [..myList];
    }

    public string StringifyList(List<int> list)
    {
        var acc = "";
        list.ForEach(s => acc += s + ",");
        acc = acc.TrimEnd(',');
        return acc;
    }

    public List<int> FilterListOddNumbers(List<int> list)
    {
        return list.Where(x => (x % 2) != 0).ToList();
    }

    public List<int> FilterListEvenNumbers(List<int> list)
    {
        return list.Where(x => (x % 2) == 0).ToList();
    }

    public List<int> SortAscending(List<int> list)
    {
        return list.OrderBy(x => x).ToList();
    }
    
    public List<int> SortDescending(List<int> list)
    {
        return list.OrderByDescending(x => x).ToList();
    }

    private void Odd_Click(object sender, RoutedEventArgs e)
    {
        myList = FilterListOddNumbers(myList);
        MyTextBlock.Text = StringifyList(myList);
    }

    private void Even_Click(object sender, RoutedEventArgs e)
    {
        myList = FilterListEvenNumbers(myList);
        MyTextBlock.Text = StringifyList(myList);
    }

    private void RemoveFilter_Click(object sender, RoutedEventArgs e)
    {
        myList = [..defaultList];
        MyTextBlock.Text = StringifyList(myList);
    }

    private void Asc_OnClick(object sender, RoutedEventArgs e)
    {
        myList = SortAscending(myList);
        MyTextBlock.Text = StringifyList(myList);
    }

    private void Desc_OnClick(object sender, RoutedEventArgs e)
    {
        myList = SortDescending(myList);
        MyTextBlock.Text = StringifyList(myList);
    }
}