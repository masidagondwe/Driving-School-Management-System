using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace DrivingSchoolManagementSystem.Converters
{
    public class ProgressToEnabledConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //When Progress Bar is Visible > Controls Enabled is False
            bool b = true;
            Visibility v = Visibility.Hidden;

            try
            {
                v = (Visibility)value;

                switch (v)
                {
                    case Visibility.Visible:
                        b = false;
                        break;

                    default:
                        b = true;
                        break;
                }
            }
            catch { b = true; v = Visibility.Hidden; }

            return b;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Visibility.Hidden;
        }
    }
}
