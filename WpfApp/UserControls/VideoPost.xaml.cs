using System.Windows.Controls;
using System.Windows.Input;
using WpfApp.Models;

namespace WpfApp.UserControls;

public partial class VideoPost : UserControl
{
    public VideoPost(VideoPostModel videoPostModel)
    {
        InitializeComponent();
        VideoPlayer.Source = videoPostModel.VideoPlayersource;
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