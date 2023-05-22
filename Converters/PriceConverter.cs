using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace RDA.Project.Okno.Converters
{
    public class PriceConverter : IValueConverter
    {
        public object Convert (object value, Type targetType, object parametr, System.Globalization.CultureInfo culture)
        {
            return $"$ {value}";
        }
        public object ConvertBack(object value, Type targetType, object parametr, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();    
        }
    }
}
