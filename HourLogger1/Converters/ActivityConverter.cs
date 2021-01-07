using HourLogger.Models;
using HourLogger.Repository;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Xml.Linq;

namespace HourLogger.Converters
{
    class ActivityConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var id = values[0];
            var description = values[1] as string;
            var duration = values[2] as string;
            var stringDate = values[3] as string;
            var department = "dummy";

            if (description != "" && duration != "" && stringDate != "" && department != "")
            {
                var date = DateTime.ParseExact(stringDate, "yy/MM/dd", null);
                return new Activity((int)id, description, duration, date, department);
            }

            return "";
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
