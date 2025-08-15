using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LazyPinger.Base.IServices;
using LazyPinger.Base.Models;
using LazyPinger.Core.Services;
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
        private string selectedNetworkInterface;

        [ObservableProperty]
        public AnimationHandler animationHandler = new();

        [ObservableProperty]
        public UserSelection userSelection = new();

        private INetworkService networkService;

        public MainViewModel(INetworkService networkService)
        {
            InitMainVm(networkService);
            this.networkService = networkService;
            //this.networkService = networkService;
        }

        private void InitMainVm(INetworkService networkService)
        {
            MainThread.InvokeOnMainThreadAsync(async () => {
                 await networkService.InitNetworkSettings();
                 var addresses = networkService.NetworkSettings.HostAddresses.Where(o => o.AddressFamily == AddressFamily.InterNetwork).Select(o => o.ToString());
                 DetectedNetworkInterfaces = new ObservableCollection<string>(addresses);
                 //await InitDummyDevices();
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
                Port = "50",
            };

            for (int i = 0; i < 1000; i++) {
                DetectedDevices.Add(temp);
                await Task.Delay(100);
            }
        }

        [RelayCommand]
        public void PingAll()
        {
            MainThread.InvokeOnMainThreadAsync(async () => {
                await networkService.PingAll(ref detectedDevices);
            });
        }

        partial void OnSelectedNetworkInterfaceChanged(string newValue)
        {
            detectedDevices.Clear();

            var res = GetSubnetFromIp(newValue);

            if (res is null)
                return;

            networkService.NetworkSettings.SubnetAddress = res;

            MainThread.InvokeOnMainThreadAsync(async () => {
                await networkService.PingAll(ref detectedDevices);
            });
        }

        private string? GetSubnetFromIp(string ip)
        {
            var list = ip.Split('.').ToList();
            var subnet = "";
            list.Take(list.Count - 1).ToList().ForEach(o => subnet += $"{o}.");
            return subnet;
        }

    }
}
