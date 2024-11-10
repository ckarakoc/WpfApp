using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace WpfApp.UserControls;

public partial class PostOperationsUC : UserControl
{
    public bool PostLiked { get; set; }

    public PostOperationsUC()
    {
        InitializeComponent();
    }

    public void LikePost()
    {
        Hearth.Source = new BitmapImage(
            new Uri(Environment.CurrentDirectory + @"\..\..\..\Icons\like.png", UriKind.RelativeOrAbsolute));
        PostLiked = true;
    }

    public void UnlikePost()
    {
        Hearth.Source = new BitmapImage(
            new Uri(Environment.CurrentDirectory + @"\..\..\..\Icons\nolike.png", UriKind.RelativeOrAbsolute));
        PostLiked = false;
    }

    private void Hearth_OnMouseDown(object sender, MouseButtonEventArgs e)
    {
        if (!PostLiked)
        {
            LikePost();
        }
        else
        {
            UnlikePost();
        }
    }
}