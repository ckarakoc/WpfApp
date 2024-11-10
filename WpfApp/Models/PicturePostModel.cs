using System.Windows.Media.Imaging;
using WpfApp.Database;

namespace WpfApp.Models;

public class PicturePostModel
{
    BitmapImage _postImage;
    
    public BitmapImage PostImage { get
    {
        if (_postImage == null)
        {
            return MockDb.GetPostPicture();
        }
        else
        {
            return _postImage;
        }
    } set => _postImage = value; }
}