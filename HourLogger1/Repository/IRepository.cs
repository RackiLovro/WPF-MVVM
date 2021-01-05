using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourLogger.Repository
{
    interface IRepository<Model>
    {
        int Id();
        void Add(Model model);
        void Edit(Model model);
        void Delete(Model model);
        ObservableCollection<Model> All();
        Model Get(int id);
    }
}
