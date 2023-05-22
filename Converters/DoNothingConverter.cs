using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Documents;

namespace RDA.Project.Okno.Converters
{
    public class DoNothingConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parametr, System.Globalization.CultureInfo culture)
        {
            return value;
        }
        public object ConvertBack(object value, Type targetType, object parametr, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
