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
        public void Add(Department model)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Department> All()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public int Id()
        {
            throw new NotImplementedException();
        }
    }
}
