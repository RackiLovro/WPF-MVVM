using HourLogger.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace HourLogger.Converters
{
        class ProjectConverter : IMultiValueConverter
        {
            public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
            {
                var project = values[0] as Project;
                var name = values[1] as string;
                var activities = new ObservableCollection<Activity>();

                if (project != null && name != null)
                {
                    return new Project(project.Id, name, activities);
                }

                return "";
            }

            public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
            {
                throw new NotImplementedException();
            }
        }
}
