using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace WpfApp;

public partial class CatYearsUI : Window
{
    public TextBlock ResultTextBlock;
    public TextBox InputCatAge;

    public CatYearsUI()
    {
        InitializeComponent();

        var projectRoot = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.Parent?.FullName;

        Image? backgroundImage = null;
        if (projectRoot != null)
        {
            backgroundImage = new Image()
            {
                Source = new BitmapImage(new Uri(System.IO.Path.Combine(projectRoot, "Images", "Cat.jpg"),
                    UriKind.RelativeOrAbsolute))
            };
        }

        ResultTextBlock = new TextBlock()
        {
            Text = "Your cat is ",
            FontSize = 18
        };

        InputCatAge = new TextBox()
        {
            Width = 120,
            TextAlignment = TextAlignment.Center,
            FontSize = 16,
            Margin = new Thickness(5, 0, 0, 0),
        };

        InputCatAge.KeyDown += InputCatAge_OnKeyDown;

        TextBlock userQuestion = new TextBlock() {Text = "How old is your cat?", FontSize = 18};
        StackPanel horStackPanel = new StackPanel()
            {Orientation = Orientation.Horizontal, Margin = new Thickness(1, 5, 0, 0)};
        horStackPanel.Children.Add(userQuestion);
        horStackPanel.Children.Add(InputCatAge);

        StackPanel mainStackPanel = new StackPanel();
        mainStackPanel.Children.Add(horStackPanel);
        mainStackPanel.Children.Add(ResultTextBlock);
        if (backgroundImage != null) mainStackPanel.Children.Add(backgroundImage);

        Cat.Content = mainStackPanel;
    }

    private void InputCatAge_OnKeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter)
        {
            try
            {
                int inputCatAge = Int32.Parse(InputCatAge.Text);
                string resultHumanAge = "";
                if (inputCatAge > 0 && inputCatAge <= 1)
                {
                    resultHumanAge = "0-15";
                }
                else if (inputCatAge >= 2 && inputCatAge < 25)
                {
                    resultHumanAge = (((inputCatAge - 2) * 4) + 24).ToString();
                }
                else
                {
                    resultHumanAge = "\u221e";
                }

                ResultTextBlock.Text = "Your cat is " + resultHumanAge + " years old";
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("Not a valid number");
                InputCatAge.Clear();
            }
        }
    }
}