using System.IO;
using System.Windows.Media.Imaging;

namespace WpfApp.Database;

public class MockDb
{
    public static Uri GetPostVideo()
    {
        return new Uri(Environment.CurrentDirectory + @"\..\..\..\Videos\cat.mp4", UriKind.RelativeOrAbsolute);
    }

    public static BitmapImage GetPostPicture()
    {
        List<string> filepaths = Directory.GetFiles(Environment.CurrentDirectory + @"\..\..\..\Icons\", "post*.jpg").ToList();
        Random random = new Random(DateTime.Now.Millisecond);

        FileInfo fileInfo = new FileInfo(filepaths[random.Next(filepaths.Count)]);

        return new BitmapImage(new Uri(fileInfo.FullName, UriKind.RelativeOrAbsolute));
    }
}