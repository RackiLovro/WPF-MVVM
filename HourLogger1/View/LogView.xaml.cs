﻿using HourLogger.ViewModel;
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

namespace HourLogger.View
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class LogView : Window
    {
        static readonly Database _database = Database.Instance;
        public LogView()
        {
            InitializeComponent();
            LogViewModel LVM = new LogViewModel(_database);
            this.DataContext = LVM;
        }

    }
}
