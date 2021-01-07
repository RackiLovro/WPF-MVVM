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
    class UserRepository : IRepository<User>
    {
        private readonly Database _database;
        public UserRepository(Database database)
        {
            this._database = database;
        }
        public void Add(User model)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<User> All()
        {
            var departmentRepository = new DepartmentRepository(_database);
            var users = new ObservableCollection<User>();

            var elements = _database.Element("database").Element("users").Elements("user");

            foreach (var element in elements)
            {
                var id = Int32.Parse(element.Attribute("id").Value);
                var username = element.Attribute("username").Value;
                var memberSince = DateTime.ParseExact(element.Attribute("memberSince").Value, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                var department = departmentRepository.Get(id);

                users.Add(new User(id, username, memberSince, department));
            }

            return users;
        }

        public void Delete(User model)
        {
            throw new NotImplementedException();
        }

        public void Edit(User model)
        {
            var id = model.Id;

            var element = _database.Element("database").Descendants().Elements("user").Single(x => (int)x.Attribute("id") == id);

            element.Attribute("memberSince").Value = model.StringMemberSince;
            element.Attribute("departmentId").Value = model.Department.Id.ToString();

            _database.Save();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public int Id()
        {
            throw new NotImplementedException();
        }
    }
}
