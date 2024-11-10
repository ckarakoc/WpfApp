using System.Windows.Controls;
using System.Windows.Input;
using WpfApp.Models;

namespace WpfApp.UserControls;

public partial class PicturePost : UserControl
{
    public PicturePost(PicturePostModel picturePostModel)
    {
        InitializeComponent();
        ImageOfPost.Source = picturePostModel.PostImage;
    }

    private void Control_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
        if (!PostOps.PostLiked)
        {
            PostOps.LikePost();
        }
        else
        {
            PostOps.UnlikePost();
        }
    }
}