using HourLogger.Commands;
using HourLogger.Models;
using HourLogger.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HourLogger.ViewModel
{
    class UpdateProjectViewModel
    {
        private MainViewViewModel _mainViewViewModel;
        private Project _project;

        public UpdateProjectViewModel(Project project, MainViewViewModel mainViewViewModel)
        {
            _project = project;
            _mainViewViewModel = mainViewViewModel;
        }
        public Project Project
        {
            get { return _project; }
        }

        public int Id
        {
            get { return _project.Id; }
        }

        public string Name
        {
            get { return _project.Name; }
        }

        private ICommand _update;

        public ICommand UpdateCommand
        {
            get
            {
                if (_update == null) _update = new RelayCommand(o =>
                {
                    _mainViewViewModel.ProjectRepository.Edit(o as Project);
                    _mainViewViewModel.Projects.Clear();
                    _mainViewViewModel.Projects = _mainViewViewModel.ProjectRepository.All();
                },
                    o => true
                    );
                return _update;
            }
            set
            {
                _update = value;
            }
        }
    }
}
