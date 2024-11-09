using System.Windows;
using System.Windows.Input;

namespace WpfApp;

public partial class CatYears : Window
{
    public CatYears()
    {
        InitializeComponent();
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