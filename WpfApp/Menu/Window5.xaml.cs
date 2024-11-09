using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace WpfApp.Menu;

public partial class Window5 : Window
{
    public Window5()
    {
        InitializeComponent();
    }

    private void OpenFileButton_Click(object sender, RoutedEventArgs e)
    {
        var openFileDialog = new OpenFileDialog
        {
            InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            Filter = "Text files (*.txt)|*.txt|All Files (*.*)|*.*",
        };

        if (openFileDialog.ShowDialog() == true)
        {
            TextEditor.Text = File.ReadAllText(openFileDialog.FileName);
        }
    }

    private void SaveFileButton_Click(object sender, RoutedEventArgs e)
    {
        var saveFileDialog = new SaveFileDialog()
        {
            InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            Filter = "Text files (*.txt)|*.txt|All Files (*.*)|*.*",
        };
        if (saveFileDialog.ShowDialog() == true)
        {
            File.WriteAllText(saveFileDialog.FileName, TextEditor.Text);
        }
    }
}