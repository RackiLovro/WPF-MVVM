using HourLogger.Commands;
using HourLogger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HourLogger.ViewModel
{
    class AddActivityViewModel
    {
        private readonly int _id;
        private readonly Project _project;
        private readonly MainViewViewModel _mainViewViewModel;
        public AddActivityViewModel(MainViewViewModel mainViewViewModel, Project project)
        {
            _id = mainViewViewModel.ActivityRepository.Id();
            _project = project;
            _mainViewViewModel = mainViewViewModel;
        }
        public int Id
        {
            get { return _id; }
        }

        private ICommand _add;

        public ICommand AddCommand
        {
            get
            {
                if (_add == null) _add = new RelayCommand(o =>
                {
                    var activity = o as Activity;
                    activity.Department = this._mainViewViewModel.LogViewModel.Department;
                    _mainViewViewModel.ActivityRepository.Add(_project, activity);
                    _mainViewViewModel.Projects.Clear();
                    _mainViewViewModel.Projects = _mainViewViewModel.ProjectRepository.All();
                },
                    o => true
                    );
                return _add;
            }
            set
            {
                _add = value;
            }
        }
    }
}
