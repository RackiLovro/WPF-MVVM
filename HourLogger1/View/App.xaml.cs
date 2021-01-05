using HourLogger.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HourLogger.View
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static readonly Database _database = Database.Instance;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainView window = new MainView();
            MainViewViewModel VM = new MainViewViewModel(_database);
            window.DataContext = VM;
        }
    }
}
