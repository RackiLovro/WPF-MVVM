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
using System.Windows.Shapes;
using System.Xml.Linq;

namespace HourLogger
{
    /// <summary>
    /// Interaction logic for SwitchDivision.xaml
    /// </summary>
    public partial class SwitchDivision : Window
    {
        public SwitchDivision()
        {
            InitializeComponent();

            XDocument document = XDocument.Load("database.xml");

            var projects = document.Element("database").Element("departments").Elements("department");

            foreach (var el in projects)
            {
                ListBoxItem item = new ListBoxItem();
                string name = el.Attribute("departmentname").Value;
                item.Content = name;

                division.Items.Add(item);
            }
        }

        public void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void Save(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
