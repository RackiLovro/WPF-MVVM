using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace HourLogger
{
    /// <summary>
    /// Interaction logic for AddActivity.xaml
    /// </summary>
    public partial class CreateActivity : Window
    {
        public CreateActivity()
        {
            InitializeComponent();

            XDocument document = XDocument.Load("database.xml");

            var projects = document.Element("database").Element("projects").Elements("project");

            foreach (var el in projects)
            {
                ListBoxItem item = new ListBoxItem();
                string name = el.Attribute("name").Value;
                item.Content = name;

                activityProject.Items.Add(item);
            }
        }

        public void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void Save(object sender, RoutedEventArgs e)
        {
            String project = (activityProject.SelectedItem as ListBoxItem).Content.ToString();
            String description = activityDescription.Text.ToString();
            String date = activityDate.SelectedDate.Value.Date.ToString("dd.MM.yyyy");
            String duration = (activityDuration.SelectedItem as ListBoxItem).Content.ToString();

            XDocument document = XDocument.Load("database.xml");

            document.Element("database").Element("projects").Elements("project")
                    .Single(x => (String)x.Attribute("name") == project)
                    .Add(new XElement("activity", new XAttribute("description", description), new XAttribute("date", date), new XAttribute("duration", duration)));

            document.Save("database.xml");

            this.Close();
        }
    }
}
