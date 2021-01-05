using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Interaction logic for UpdateActivity.xaml
    /// </summary>
    public partial class UpdateActivity : Window
    {
        public UpdateActivity()
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

        public void SelectProject(object sender, RoutedEventArgs e)
        {
            activityDescription.Items.Clear();
            updateDescription.Clear();
            updateDate.SelectedDate = null;
            updateDuration.UnselectAll();

            XDocument document = XDocument.Load("database.xml");
            String project = (activityProject.SelectedItem as ListBoxItem).Content.ToString();

            var activities = document.Element("database").Element("projects").Elements("project").Where(x => (String)x.Attribute("name") == project).Descendants();

            foreach (XElement el in activities)
            {
                ListBoxItem item = new ListBoxItem();
                string description = el.Attribute("description").Value;
                item.Content = description;

                activityDescription.Items.Add(item);
            }
        }

        public void SelectActivity(object sender, RoutedEventArgs e)
        {
            if(activityDescription.SelectedItem != null)
            {
                XDocument document = XDocument.Load("database.xml");

                String project = (activityProject.SelectedItem as ListBoxItem).Content.ToString();
                String description = (activityDescription.SelectedItem as ListBoxItem).Content.ToString();

                var activity = document.Element("database").Element("projects").Elements("project")
                        .Where(x => (String)x.Attribute("name") == project)
                        .Descendants()
                        .Single(x => (String)x.Attribute("description") == description);

                updateDate.SelectedDate = DateTime.ParseExact(activity.Attribute("date").Value, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                updateDescription.Text = description;
                updateDuration.SelectedItem = updateDuration.Items.GetItemAt(Int32.Parse(activity.Attribute("duration").Value.ToString()) - 1);
            }
        }

        public void Update(object sender, RoutedEventArgs e)
        {
            XDocument document = XDocument.Load("database.xml");

            String project = (activityProject.SelectedItem as ListBoxItem).Content.ToString();
            String description = (activityDescription.SelectedItem as ListBoxItem).Content.ToString();
            
            var element = document.Element("database").Element("projects").Elements("project").Where(x => (String)x.Attribute("name") == project).Descendants().Single(x => (String)x.Attribute("description") == description);

            String newDescription = updateDescription.Text;
            String newDate = updateDate.SelectedDate.Value.Date.ToString("dd.MM.yyyy");
            String newDuration = (updateDuration.SelectedItem as ListBoxItem).Content.ToString();

            element.Attribute("description").Value = newDescription;
            element.Attribute("date").Value = newDate;
            element.Attribute("duration").Value = newDuration;

            document.Save("database.xml");

            this.Close();
        }

        public void Delete(object sender, RoutedEventArgs e)
        {
            XDocument document = XDocument.Load("database.xml");

            String project = (activityProject.SelectedItem as ListBoxItem).Content.ToString();
            String description = (activityDescription.SelectedItem as ListBoxItem).Content.ToString();

            document.Element("database").Element("projects").Elements("project").Where(x => (String)x.Attribute("name") == project).Descendants().Single(x => (String)x.Attribute("description") == description).Remove();

            document.Save("database.xml");

            this.Close();
        }
    }
}
