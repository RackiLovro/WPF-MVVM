using HourLogger.Commands;
using HourLogger.Models;
using HourLogger.Repository;
using HourLogger.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace HourLogger.ViewModel
{
    class MainViewViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Project> _projects;
        private readonly LogViewModel _logViewModel;
        private readonly ProjectRepository _projectRepository;
        private readonly ActivityRepository _activityRepository;

        public MainViewViewModel(Database database, LogViewModel logViewModel)
        {
            _projectRepository = new ProjectRepository(database);
            _activityRepository = new ActivityRepository(database);
            _projects = _projectRepository.All();
            _logViewModel = logViewModel;
        }
        public LogViewModel LogViewModel
        {
            get { return _logViewModel; }
        }
        public ActivityRepository ActivityRepository
        {
            get { return _activityRepository; }
        }
        public ProjectRepository ProjectRepository
        {
            get { return _projectRepository; }
        }
        public ObservableCollection<Project> Projects
        {
            get { return _projects; }
            set { _projects = value;
                OnPropertyChanged("Projects");
            }
        }

        private void OnPropertyChanged(string info)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(info));
        }

        private ICommand _addActivity;
        public ICommand AddActivity
        {
            get
            {
                if (_addActivity == null) _addActivity = new RelayCommand(o =>
                {
                    var addActivity = new AddActivity
                    {
                        DataContext = new AddActivityViewModel(this, o as Project)
                    };
                    addActivity.Show();
                },
                    o => true
                    );
                return _addActivity;
            }
            set
            {
                _addProject = value;
            }
        }

        private ICommand _addProject;

        public ICommand AddProject
        {
            get
            {
                if (_addProject == null) _addProject = new RelayCommand(o =>
                {
                    var addProject = new AddProject
                    {
                        DataContext = this
                    };
                    addProject.Show();
                },
                    o => true
                    );
                return _addProject;
            }
            set
            {
                _addProject = value;
            }
        }
        private ICommand _updateProject;

        public ICommand UpdateProject
        {
            get
            {
                if (_updateProject == null) _updateProject = new RelayCommand(o =>
                {
                    var updateProject = new UpdateProject
                    {
                        DataContext = new UpdateProjectViewModel(o as Project, this)
                    };
                    updateProject.Show();
                },
                    o => true
                    );
                return _updateProject;
            }
            set
            {
                _updateProject = value;
            }
        }
        private ICommand _updateActivity;
        public ICommand UpdateActivity
        {
            get
            {
                if (_updateActivity == null) _updateActivity = new RelayCommand(o =>
                {
                    var updateActiivty = new UpdateActivity
                    {
                        DataContext = new UpdateActivityViewModel(this, o as Activity)
                    };
                    updateActiivty.Show();
                },
                    o => true
                    );
                return _updateActivity;
            }
            set
            {
                _updateActivity = value;
            }
        }

        private ICommand _deleteActivity;

        public ICommand DeleteActivity
        {
            get
            {
                if (_deleteActivity == null) _deleteActivity = new RelayCommand(o =>
                {
                    _activityRepository.Delete(o as Activity);
                    this.Projects = _projectRepository.All();
                },
                    o => true
                    );
                return _deleteActivity;
            }
            set
            {
                _deleteActivity = value;
            }
        }

        private ICommand _delete;

        public ICommand DeleteCommand
        {
            get
            {
                if (_delete == null) _delete = new RelayCommand(o =>
                {
                    _projects.Remove((Project)o);
                    _projectRepository.Delete((Project)o);
                },
                    o => true
                    );
                return _delete;
            }
            set
            {
                _delete = value;
            }
        }


        private ICommand _add;

        public ICommand AddCommand
        {
            get
            {
                if (_add == null) _add = new RelayCommand(o =>
                {
                    var id = _projectRepository.Id();
                    var name = (string)o;
                    var activities = new ObservableCollection<Activity>();

                    Project project = new Project(id, name, activities);

                    this._projectRepository.Add(project);
                    this._projects.Add(project);
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

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
