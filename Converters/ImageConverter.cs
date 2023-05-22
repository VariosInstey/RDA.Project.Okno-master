using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace RDA.Project.Okno.Converters
{
    public class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parametr, System.Globalization.CultureInfo culture)
        {
            if (targetType != typeof(ImageSource))
                throw new InvalidOperationException("Target type must be System.Windows.Media.ImageSource");

            try
            {
                BitmapImage img = new BitmapImage();
                img.BeginInit();
                img.UriSource = new Uri("/RDA.Project.Okno/Images/Window" + value + ".png", UriKind.Relative);
                img.EndInit();
                return img;
            }
            catch 
            { 
            return DependencyProperty.UnsetValue;
            }   
        }
        public object ConvertBack (object value, Type targetType, object parametr, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
