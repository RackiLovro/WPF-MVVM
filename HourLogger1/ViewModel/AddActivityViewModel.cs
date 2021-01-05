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
        private int _id;
        private Project _project;
        private MainViewViewModel _mainViewViewModel;
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
                    _mainViewViewModel.ActivityRepository.Add(_project, o as Activity);
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
