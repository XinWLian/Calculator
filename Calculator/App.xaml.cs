﻿using Calculator.Model;
using Calculator.Stores;
using Calculator.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private CalculatorHistory _calculations;
        private NavigationStore _navigationStore;

        public App()
        {
            _calculations = new CalculatorHistory();
            _navigationStore = new NavigationStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = new CalculatorViewModel(_calculations);
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_calculations,_navigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
