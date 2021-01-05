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
    /// Interaction logic for UpdateProject.xaml
    /// </summary>
    public partial class UpdateProject : Window
    {
        public UpdateProject()
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

        public void SelectProject(object sender, RoutedEventArgs e)
        {
            projectName.Text = (activityProject.SelectedItem as ListBoxItem).Content.ToString();
        }

        public void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void Update(object sender, RoutedEventArgs e)
        {
            XDocument document = XDocument.Load("database.xml");

            String project = (activityProject.SelectedItem as ListBoxItem).Content.ToString();

            document.Element("database").Element("projects").Elements("project").Single(x => (String)x.Attribute("name") == project).Attribute("name").Value = projectName.Text;

            document.Save("database.xml");

            this.Close();
        }

        public void Delete(object sender, RoutedEventArgs e)
        {
            XDocument document = XDocument.Load("database.xml");

            String project = (activityProject.SelectedItem as ListBoxItem).Content.ToString();

            document.Element("database").Element("projects").Elements("project").Single(x => (String)x.Attribute("name") == project).Remove();
            
            document.Save("database.xml");

            this.Close();
        }
    }
}
