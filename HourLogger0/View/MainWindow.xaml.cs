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

namespace HourLogger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LoginWindow l = new LoginWindow();
            l.Show();
        }

        private void AddProject(object sender, RoutedEventArgs e)
        {
            CreateProject p = new CreateProject();
            p.Show();
        }

        private void AddActivity(object sender, RoutedEventArgs e)
        {
            CreateActivity a = new CreateActivity();
            a.Show();
        }

        private void UpdateProject(object sender, RoutedEventArgs e)
        {
            UpdateProject p = new UpdateProject();
            p.Show();
        }

        private void UpdateActivity(object sender, RoutedEventArgs e)
        {
            UpdateActivity a = new UpdateActivity();
            a.Show();
        }

        private void SwitchDivision(object sender, RoutedEventArgs e)
        {
            SwitchDivision d = new SwitchDivision();
            d.Show();
        }
    }
}
