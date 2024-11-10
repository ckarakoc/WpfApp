using WpfApp.Database;

namespace WpfApp.Models;

public class VideoPostModel
{
    private Uri _videoPlayersource;

    public Uri VideoPlayersource
    {
        get
        {
            if (_videoPlayersource == null)
            {
                return MockDb.GetPostVideo();
            }
            else
            {
                return _videoPlayersource;
            }
        }
        set => _videoPlayersource = value;
    }
}