using System.Speech.Synthesis;
using System.Windows;

namespace WpfApp.Other;

public partial class Window5 : Window
{
    private SpeechSynthesizer speechSynthesizer;
    
    public Window5()
    {
        InitializeComponent();
        speechSynthesizer = new SpeechSynthesizer()
        {
            Volume = 100,
            Rate = 1,
        };
        speechSynthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        speechSynthesizer.Speak(MainTextBox.Text);
    }
}