using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Screeny
{
    /// <summary>
    /// Interaction logic for FullscreenImage.xaml
    /// </summary>
    public partial class FullscreenImage : Window
    {
        public FullscreenImage(ImageSource source)
        {
            InitializeComponent();
            image.ImageSource = source;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                this.Close();
            }
        }


        private void surface_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //http://csharphelper.com/blog/2014/12/let-user-move-resize-rectangle-wpf-c/
        }
    }
}
