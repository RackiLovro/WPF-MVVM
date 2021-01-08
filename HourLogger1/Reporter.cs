using HourLogger.Models;
using HourLogger.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourLogger
{
    class Reporter
    {
        public Reporter()
        {
        }

        public static void GenerateReport(Database database)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Racki\Documents\Reports.txt"))
            {
                var projects = new ProjectRepository(database).All();
                var activityRepository = new ActivityRepository(database);

                foreach (Project project in projects.ToList())
                {
                    file.WriteLine("------" + project.Name);
                    file.WriteLine("Description------Duration------Date------Percent Duration");
                    ObservableCollection<Activity> _activities = activityRepository.All(project.Id);

                    var duration = _activities.ToList().Sum(x => int.Parse(x.Duration));

                    foreach (Activity activity in _activities.ToList())
                    {
                        double percentDuration = double.Parse(activity.Duration) / duration;

                        file.WriteLine(string.Format("{0}-{1}-{2}-{3}", activity.Description, activity.Duration, activity.Date.ToString("dd.mm.yyyy"), Math.Round(percentDuration, 2)));
                    }
                }
            }
        }
    }
}
