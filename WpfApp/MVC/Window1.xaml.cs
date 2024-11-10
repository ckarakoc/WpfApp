using System.Windows;
using System.Windows.Controls;
using WpfApp.Models;
using WpfApp.UserControls;

namespace WpfApp.MVC;

public partial class Window1 : Window
{
    private Random generator;

    public Window1()
    {
        InitializeComponent();

        generator = new Random(DateTime.Now.Millisecond);
        MainStackPanel.Children.Add(new VideoPost(new VideoPostModel()));
        MainStackPanel.Children.Add(new PicturePost(new PicturePostModel()));
        MainStackPanel.Children.Add(new VideoPost(new VideoPostModel()));
        MainStackPanel.Children.Add(new PicturePost(new PicturePostModel()));
    }

    private void MainScrollViewer_OnScrollChanged(object sender, ScrollChangedEventArgs e)
    {
        if (e.VerticalChange > 0)
        {
            int adjustment = 400;
            if (e.VerticalOffset + e.ViewportHeight + adjustment >= e.ExtentHeight)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (generator.Next(0, 100) < 70)
                    {
                        MainStackPanel.Children.Add(new PicturePost(new PicturePostModel()));
                    }
                    else
                    {
                        MainStackPanel.Children.Add(new VideoPost(new VideoPostModel()));
                    }
                }
            }
        }
    }
}