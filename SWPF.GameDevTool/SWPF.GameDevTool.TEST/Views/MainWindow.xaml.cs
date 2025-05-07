using Prism.Regions;
using SWPF.GameDevTool.TEST.ViewModels;
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
        private MainViewModel _viewModel = new MainViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = _viewModel;
        }

        private async void ConnectGrpc_Click(object sender, RoutedEventArgs e) => await _viewModel.InitializeGrpc();
        private async void ConnectTcp_Click(object sender, RoutedEventArgs e) => await _viewModel.InitializeTcp();
        private async void ConnectHttp_Click(object sender, RoutedEventArgs e) => await _viewModel.InitializeHttp();
        private async void SendMessage_Click(object sender, RoutedEventArgs e) => await _viewModel.SendMessage();
    }
}
