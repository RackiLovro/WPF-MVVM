using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace HourLogger
{
    /// <summary>
    /// Interaction logic for AddProject.xaml
    /// </summary>
    public partial class CreateProject : Window
    {
        public CreateProject()
        {
            InitializeComponent();
        }

        public void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void Save(object sender, RoutedEventArgs e)
        {
            String name = projectName.Text.ToString();

            XDocument document = XDocument.Load("database.xml");

            document.Element("database").Element("projects")
                    .Add(new XElement("project", new XAttribute("name", name)));

            document.Save("database.xml");

            this.Close();
        }
    }
}
