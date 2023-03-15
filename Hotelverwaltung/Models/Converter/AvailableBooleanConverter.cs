using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelverwaltung.Models.Converter
{
    class AvailableBooleanConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value is bool boolValue) {
                if (boolValue) {
                    return "Frei";
                }
                else {
                    return "Belegt";
                }
            }

            return "N/A";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            if(value is string stringValue) {
                if (stringValue == "Frei") {
                    return true;
                }
                else {
                    return false;
                }
            }
            return false;
        }
    }
}
