using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourLogger.Models
{
    class Project : INotifyPropertyChanged
    {
        private int _id;
        private string _name;
        private ObservableCollection<Activity> _activities;

        public Project()
        {
        }
        public Project(int id, string name, ObservableCollection<Activity> activities)
        {
            _id = id;
            _name = name;
            _activities = activities;
        }
        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("ProjectName");
            }
        }
        public ObservableCollection<Activity> Acitvities
        {
            get { return _activities; }
            set
            {
                _activities = value;
                OnPropertyChanged("Actvities");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string info)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}
