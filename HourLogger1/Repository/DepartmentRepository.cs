using HourLogger.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourLogger.Repository
{
    class DepartmentRepository : IRepository<Department>
    {
        private readonly Database _database;
        public DepartmentRepository(Database database)
        {
            this._database = database;
        }
        public void Add(Department model)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Department> All()
        {
            var departments = new ObservableCollection<Department>();

            var elements = _database.Element("database").Element("departments").Elements("department");

            foreach (var element in elements)
            {
                var id = Int32.Parse(element.Attribute("id").Value);
                var name = element.Attribute("name").Value;

                departments.Add(new Department(id, name));
            }

            return departments;
        }

        public void Delete(Department model)
        {
            throw new NotImplementedException();
        }

        public void Edit(Department model)
        {
            throw new NotImplementedException();
        }

        public Department Get(int id)
        {
            var activity = _database.Element("database").Descendants("department").Single(x => (Int32)x.Attribute("id") == id);

            var name = activity.Attribute("name").Value;

            return new Department(id, name);
        }

        public int Id()
        {
            throw new NotImplementedException();
        }
    }
}
