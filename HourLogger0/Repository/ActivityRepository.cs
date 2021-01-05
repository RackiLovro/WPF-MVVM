using HourLogger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HourLogger.Repository
{
    class ActivityRepository
    {
        private Database dbContext;
        public ActivityRepository(Database database)
        {
            this.dbContext = database;
        }

        public List<Activity> GetActivities(Project project)
        {
            /*
            dbContext.Element("database").Element("projects").Elements("project")
                     .Where(x => (String)x.Attribute("name") == project).Descendants()
                     .ToList().ForEach(x => activities.Append(new Activity(x.Attribute("description").Value,x.Attribute("duration").Value, x.Attribute("date").Value, x.Attribute("department").Value)));
            
            var activities = new List<Activity>();
            var projectName = project.projectName;

            var elements = dbContext.Element("database").Element("projects").Elements("project")
                                    .Where(x => (String)x.Attribute("name") == projectName).Descendants();

            foreach (var element in elements)
            {
                var description = element.Attribute("description").Value;
                var duration = element.Attribute("duration").Value;
                var date = element.Attribute("date").Value;
                var department = element.Attribute("department").Value;

                activities.Add(new Activity(description, duration, date, department));
            }
            */
            return project.activities;
        }

        public Activity GetActivity(String project, String description)
        {
            var activity = dbContext.Element("database").Element("projects").Elements("project")
                                    .Where(x => (String)x.Attribute("name") == project)
                                    .Descendants()
                                    .Single(x => (String)x.Attribute("description") == description);

            var desc = activity.Attribute("description").Value;
            var duration = activity.Attribute("duration").Value;
            var date = activity.Attribute("date").Value;
            var department = activity.Attribute("department").Value;

            return new Activity(desc, duration, date, department);
        }

        public void DeleteActivity(Activity activity)
        {

        }
    }
}
