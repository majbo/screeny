using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Screeny
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void captureScreen_Click(object sender, RoutedEventArgs e)
        {
            string test = @"c:\temp\lll.jpg";
            ScreenCapturer.CaptureAndSave(test, CaptureMode.Screen, ImageFormat.Bmp);

            var bitmap = new BitmapImage(new Uri(test));

            var fullscreenImage = new FullscreenImage(bitmap);
            fullscreenImage.Show();

        }
    }
}
