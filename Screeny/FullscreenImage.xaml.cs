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
        private Point _startPoint;
        private Rectangle _rectangle;

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
            if (_rectangle != null)
            {
                surface.Children.Remove(_rectangle);
            }
            _startPoint = e.GetPosition(surface);

            _rectangle = new Rectangle
            {
                Stroke = Brushes.LightBlue,
                StrokeThickness = 2
            };
            Canvas.SetLeft(_rectangle, _startPoint.X);
            Canvas.SetTop(_rectangle, _startPoint.X);
            surface.Children.Add(_rectangle);
        }

        private void surface_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void surface_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Released || _rectangle == null)
                return;

            var pos = e.GetPosition(surface);

            var x = Math.Min(pos.X, _startPoint.X);
            var y = Math.Min(pos.Y, _startPoint.Y);

            var w = Math.Max(pos.X, _startPoint.X) - x;
            var h = Math.Max(pos.Y, _startPoint.Y) - y;

            _rectangle.Width = w;
            _rectangle.Height = h;

            Canvas.SetLeft(_rectangle, x);
            Canvas.SetTop(_rectangle, y);
        }

    }
}
