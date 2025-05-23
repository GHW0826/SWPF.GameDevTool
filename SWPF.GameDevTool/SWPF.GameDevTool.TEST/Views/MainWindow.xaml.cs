﻿using Prism.Regions;
using SWPF.GameDevTool.TEST.Views;
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

namespace SWPF.GameDevTool.TEST
{
    /// <summary>
    /// Interaction logic for ViewA.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IRegionManager _regionManager;

        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(IRegionManager regionManager)
        {
            InitializeComponent();
            _regionManager = regionManager;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
     
        }
    }
}
