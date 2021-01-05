using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourLogger.ViewModel
{
    public class CreateActivityViewModel : ViewModelBase
    {
        private string _description;
        private string _duration;
        private string _date;
        private string _department;

        public string Description
        {
            get => _description;
            //set => SetProperty(ref _description, value);
        }
    }
}
