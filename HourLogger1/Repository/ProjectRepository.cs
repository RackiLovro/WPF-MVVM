using HourLogger.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HourLogger.Repository
{
    class ProjectRepository 
    {
        private readonly Database _database;
        public ProjectRepository(Database database)
        {
            _database = database;
        }

        public int Id()
        {
            var ids = _database.Element("database").Element("projects").Elements("project").Attributes("id")
                                        .Select(x => (Int32)x).ToList();

            var hids = Enumerable.Range(1, ids.Max() + 1).ToList();

            return hids.Except(ids).ToList().Min();
        }

        public void Add(Project model)
        {
            var id = model.Id;
            var projectName = model.Name;

            _database.Element("database").Element("projects")
                              .Add(new XElement("project", new XAttribute("id", id), new XAttribute("name", projectName)));

            _database.Save();
        }

        public void Edit(Project model)
        {
            var id = model.Id;

            _database.Element("database").Element("projects").Elements("project")
                              .Single(x => (Int32)x.Attribute("id") == id).Attribute("name").Value = model.Name;

            _database.Save();
        }

        public void Delete(Project model)
        {
            var id = model.Id;

            _database.Element("database").Element("projects").Elements("project")
                              .Single(x => (Int32)x.Attribute("id") == id).Remove();

            _database.Save();
        }

        public ObservableCollection<Project> All()
        {
            var activityRepository = new ActivityRepository(_database);
            var projects = new ObservableCollection<Project>();

            var elements = _database.Element("database").Element("projects").Elements("project");

            foreach (var element in elements)
            {
                var id = Int32.Parse(element.Attribute("id").Value);
                var name = element.Attribute("name").Value;
                var activities = activityRepository.All(id);

                projects.Add(new Project(id, name, activities));
            }

            return projects;
        }
    }
}
