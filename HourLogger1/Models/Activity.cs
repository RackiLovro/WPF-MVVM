using HourLogger.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourLogger.Models
{
    class Activity : INotifyPropertyChanged
    {
        private int _id;
        private string _description;
        private string _duration;
        private DateTime _date;
        private string _department;

        public Activity()
        {
        }
        public Activity(int id, string description, string duration, DateTime date, string department)
        {
            _id = id;
            _description = description;
            _duration = duration;
            _date = date;
            _department = department;
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
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged("Description");
            }
        }
        public string Duration
        {
            get { return _duration; }
            set
            {
                _duration = value;
                OnPropertyChanged("Duration");
            }
        }
        public DateTime Date
        {
            get { return _date.Date; }
            set
            {
                _date = value;
                OnPropertyChanged("Date");
            }
        }
        public string StringDate
        {
            get { return _date.Date.ToString("dd.MM.yyyy"); }
        }
        public string Department
        {
            get { return _department; }
            set
            {
                _department = value;
                OnPropertyChanged("Department");
            }
        }

        private void OnPropertyChanged(string info)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(info));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
