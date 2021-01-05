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
    class UpdateActivityViewModel
    {
        private Activity _activivity;
        private MainViewViewModel _mainViewViewModel;
        public UpdateActivityViewModel(MainViewViewModel mainViewViewModel, Activity activity)
        {
            _activivity = activity;
            _mainViewViewModel = mainViewViewModel;
        }

        public int Id
        {
            get { return _activivity.Id; }
        }
        public string Description
        {
            get { return _activivity.Description; }
        }

        public DateTime Date
        {
            get { return _activivity.Date; }
        }

        public string Duration
        {
            get { return _activivity.Duration; }
        }
        public string Department
        {
            get { return _activivity.Department; }
        }

        private ICommand _add;

        public ICommand AddCommand
        {
            get
            {
                if (_add == null) _add = new RelayCommand(o =>
                {
                    _mainViewViewModel.ActivityRepository.Edit(o as Activity);
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
