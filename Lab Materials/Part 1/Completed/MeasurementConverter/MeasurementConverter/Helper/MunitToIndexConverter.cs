using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeasurementConverter.ViewModel;

namespace MeasurementConverter.Helper
{
    class MunitToIndexConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Munits munits = (Munits)value;
            if (targetType != typeof(int))
                throw new Exception("MunitsConverter.Convert expected integer targetType.");
            return (int)munits;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int index = (int)value;
            if (targetType != typeof(Munits))
                throw new Exception("MunitsConverter.Convert expected integer targetType.");
            return (Munits)index;
        }
    }
}
