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
    class UserRepository : IRepository<User>
    {
        public void Add(User model)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<User> All()
        {
            throw new NotImplementedException();
        }

        public void Delete(User model)
        {
            throw new NotImplementedException();
        }

        public void Edit(User model)
        {
            throw new NotImplementedException();
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
