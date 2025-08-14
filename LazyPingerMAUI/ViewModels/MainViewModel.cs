using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LazyPinger.Base.IServices;
using LazyPinger.Base.Models;
using LazyPinger.Core.Utils;
using System.Collections.ObjectModel;
using System.Net.Sockets;

namespace LazyPingerMAUI.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        [ObservableProperty]
        private ObservableCollection<DevicePing> detectedDevices = new();

        [ObservableProperty]
        private ObservableCollection<string> detectedNetworkInterfaces = new();

        [ObservableProperty]
        public AnimationHandler animationHandler = new();

        public MainViewModel(INetworkService networkService)
        {
            InitMainVm(networkService);
            //this.networkService = networkService;
        }

        private void InitMainVm(INetworkService networkService)
        {
            MainThread.InvokeOnMainThreadAsync(async () => {
                 await networkService.InitNetworkSettings();
                 var addresses = networkService.NetworkSettings.HostAddresses.Where(o => o.AddressFamily == AddressFamily.InterNetwork).Select(o => o.ToString());
                 DetectedNetworkInterfaces = new ObservableCollection<string>(addresses);
                 await InitDummyDevices();
            });
        }

        private async Task InitDummyDevices()
        {
            var temp = new DevicePing
            {
                ID = 0,
                Description = "Dummy Device",
                IP = "192.168.0.1",
                MacAddress = "FF:FF:FF:FF",
                Name = "DummyDevice",
                Port = 50,
            };

            for (int i = 0; i < 1000; i++) {
                DetectedDevices.Add(temp);
                await Task.Delay(100);
            }
        }

        [RelayCommand]
        public Task PingAll()
        {
            return Task.CompletedTask;
        }
    }
}
