using HourLogger.Repository;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourLogger.Models
{
    class Activity
    {
        public String description;
        public String duration;
        public DateTime date;
        public String department;

        public Activity(string description, string duration, string date, string department)
        {
            this.description = description;
            this.duration = duration;
            this.date = DateTime.ParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            this.department = department;
        }

        public string DateString()
        {
            return date.Date.ToString("dd.MM.yyyy");
        }
    }
}
