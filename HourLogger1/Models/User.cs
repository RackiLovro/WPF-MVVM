using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourLogger.Models
{
    class User : INotifyPropertyChanged
    {
        private int _id;
        private string _username;
        private DateTime _memberSince;
        private Department _department;

        public User()
        {
            _id = 0;
            _username = "";
            _memberSince = DateTime.Now;
            _department = new Department();
        }

        public User(int id, string username, DateTime memberSince, Department department)
        {
            _id = id;
            _username = username;
            _memberSince = memberSince;
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
        public event PropertyChangedEventHandler PropertyChanged;
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged("Username");
            }
        }
        public string StringMemberSince
        {
            get { return _memberSince.Date.ToString("dd.MM.yyyy"); }
            set
            {
                OnPropertyChanged("MemberSince");
            }
        }
        public DateTime MemberSince
        {
            get { return _memberSince; }
            set
            {
                _memberSince = value;
                OnPropertyChanged("MemberSince");
            }
        }
        public Department Department
        {
            get { return _department; }
            set
            {
                _department = value;
                OnPropertyChanged("Department");
            }
        }
        protected void OnPropertyChanged(string info)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}
