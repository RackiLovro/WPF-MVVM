using HourLogger.Commands;
using HourLogger.Models;
using HourLogger.Repository;
using HourLogger.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HourLogger.ViewModel
{
    class LogViewModel : INotifyPropertyChanged
    {
        private  User _user;
        private readonly Database _database;
        private readonly UserRepository _userRepository;
        private readonly DepartmentRepository _departmentRepository;
        private readonly ObservableCollection<User> _users;
        private readonly ObservableCollection<Department> _departments;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string info)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(info));
        }

        public LogViewModel(Database database)
        {
            _database = database;

            _userRepository = new UserRepository(database);
            _departmentRepository = new DepartmentRepository(database);

            _users = _userRepository.All();
            _departments = _departmentRepository.All();

            _user = new User();
        }
        public DepartmentRepository DepartmentRepository
        {
            get { return _departmentRepository; }
        }
        public UserRepository UserRepository
        {
            get { return _userRepository; }
        }
        public User User
        {
            get { return _user; }
            set
            {
                _user = value;
                Username = _user.Username;
                Department = _user.Department.Name;
                Date = _user.StringMemberSince;
                OnPropertyChanged("User");
            }
        }
        public string Username
        {
            get { return _user.Username; }
            set
            {
                _user.Username = value;
                OnPropertyChanged("Username");
            }
        }
        public string Department
        {
            get { return _user.Department.Name; }
            set
            {
                _user.Department.Name = value;
                OnPropertyChanged("Department");
            }
        }
        public string Date
        {
            get { return _user.StringMemberSince; }
            set
            {
                _user.StringMemberSince = value;
                OnPropertyChanged("Date");
            }
        }
        public ObservableCollection<User> Users
        {
            get { return _users; }
        }
        public ObservableCollection<Department> Departments
        {
            get { return _departments; }
        }
        
        private ICommand _switchDepartment;

        public ICommand SwitchDepartment
        {
            get
            {
                if (_switchDepartment == null) _switchDepartment = new RelayCommand(o =>
                {
                    var department = o as Department;

                    if (department != _user.Department)
                    {
                        _user.Department = department;
                        _user.MemberSince = DateTime.Now;

                        _userRepository.Edit(_user);

                        Department = _user.Department.Name;
                        Date = _user.MemberSince.ToString("dd.MM.yyyy");
                    }
                },
                    o => true
                    );
                return _switchDepartment;
            }
            set
            {
                _switchDepartment = value;
            }
        }
        private ICommand _manage;
        public ICommand Manage
        {
            get
            {
                if (_manage == null) _manage = new RelayCommand(o =>
                {
                    var addActivity = new MainView()
                    {
                        DataContext = new MainViewViewModel(Database.Instance, this)
                    };
                    addActivity.Show();
                },
                    o => true
                    );
                return _manage;
            }
            set
            {
                _manage = value;
            }
        }

        private ICommand _generate;
        public ICommand Generate
        {
            get
            {
                if (_generate == null) _generate = new RelayCommand(o =>
                {
                    Reporter.GenerateReport(_database);
                },
                    o => true
                    );
                return _generate;
            }
            set
            {
                _generate = value;
            }
        }
    }
}
