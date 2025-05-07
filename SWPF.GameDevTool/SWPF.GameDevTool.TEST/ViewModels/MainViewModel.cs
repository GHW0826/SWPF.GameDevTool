using Prism.Commands;
using Prism.Mvvm;
using SWPF.GameDevTool.Common.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SWPF.GameDevTool.TEST.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private INetworkClient _client;

        public async Task InitializeGrpc()
        {
            _client = new GrpcClient();
            await _client.ConnectAsync("localhost", 5000);
        }

        public async Task InitializeTcp()
        {
            _client = new TcpClientWrapper();
            await _client.ConnectAsync("localhost", 5001);
        }

        public async Task InitializeHttp()
        {
            _client = new HttpClientWrapper();
            await _client.ConnectAsync("localhost", 5002);
        }

        public async Task SendMessage()
        {
            if (_client == null)
            {
                MessageBox.Show("Client not initialized");
                return;
            }

            await _client.SendAsync("Hello from WPF");
        }
    }
}
