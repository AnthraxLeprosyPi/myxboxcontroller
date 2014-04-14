using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using IValueConverter = System.Windows.Data.IValueConverter;

namespace MyXboxController.Converters {
    public class ThumbStickToThicknessConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value is J2i.Net.XInputWrapper.Point) {
                return new Thickness(((float)((J2i.Net.XInputWrapper.Point)value).X / 32767) * 10, ((float)((J2i.Net.XInputWrapper.Point)value).Y / -32767) * 10, 0, 0);
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
