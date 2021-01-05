using HourLogger.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HourLogger.Repository
{
    class ActivityRepository : IRepository<Activity>
    {
        private readonly Database _database;
        public ActivityRepository(Database database)
        {
            this._database = database;
        }

        public int Id()
        {
            var ids = _database.Element("database").Descendants().Elements("activity").Attributes("id")
                                        .Select(x => (Int32)x).ToList();

            var hids = Enumerable.Range(1, ids.Max() + 1).ToList();

            return hids.Except(ids).ToList().Min();
        }

        public void Add(Project projectModel, Activity model)
        {
            var pid = projectModel.Id;
            var id = model.Id;
            var description = model.Description;
            var date = model.StringDate;
            var duration = model.Duration;
            var department = model.Department;

            _database.Element("database").Element("projects").Elements("project")
                     .Single(x => (int)x.Attribute("id") == pid)
                     .Add(new XElement("activity", new XAttribute("id", id), 
                                                   new XAttribute("description", description), 
                                                   new XAttribute("date", date), 
                                                   new XAttribute("duration", duration), 
                                                   new XAttribute("department", department)));

            _database.Save();
        }

        public void Edit(Activity model)
        {
            var id = model.Id;

            var element = _database.Element("database").Element("projects").Descendants().Elements("activity").Single(x => (int)x.Attribute("id") == id);

            element.Attribute("description").Value = model.Description;
            element.Attribute("date").Value = model.StringDate;
            element.Attribute("duration").Value = model.Duration;
            element.Attribute("department").Value = model.Department;

            _database.Save();
        }

        public void Delete(Activity model)
        {
            var id = model.Id;

            _database.Element("database").Element("projects").Descendants().Elements("activity").Where(x => (int)x.Attribute("id") == id).Remove();

            _database.Save();
        }

        public ObservableCollection<Activity> All(int id)
        {
            var activities = new ObservableCollection<Activity>();

            var elements = _database.Element("database").Element("projects").Elements("project")
                                    .Where(x => (Int32)x.Attribute("id") == id).Descendants();

            foreach (var element in elements)
            {
                var aId = Int32.Parse(element.Attribute("id").Value);
                var description = element.Attribute("description").Value;
                var duration = element.Attribute("duration").Value;
                var date = DateTime.ParseExact(element.Attribute("date").Value, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                var department = element.Attribute("department").Value;

                activities.Add(new Activity(aId, description, duration, date, department));
            }

            return activities;
        }

        ObservableCollection<Activity> IRepository<Activity>.All()
        {
            throw new NotImplementedException();
        }

        public Activity Get(int id)
        {
            var activity = _database.Element("database").Descendants("activity").Single(x => (Int32)x.Attribute("id") == id);

            var desc = activity.Attribute("description").Value;
            var duration = activity.Attribute("duration").Value;
            var date = DateTime.ParseExact(activity.Attribute("date").Value, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var department = activity.Attribute("department").Value;

            return new Activity(id, desc, duration, date, department);
        }

        public void Add(Activity model)
        {
            throw new NotImplementedException();
        }
    }
}
