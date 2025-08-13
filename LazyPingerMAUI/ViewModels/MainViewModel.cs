using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LazyPinger.Base.IServices;
using LazyPinger.Base.Models;
using LazyPinger.Core.Utils;
using System.Collections.ObjectModel;

namespace LazyPingerMAUI.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        [ObservableProperty]
        private ObservableCollection<DevicePing> detectedDevices = new();

        [ObservableProperty]
        public AnimationHandler animationHandler = new();

        public MainViewModel(INetworkService networkService)
        {
            MainThread.InvokeOnMainThreadAsync(() => InitDummyDevices());
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
                await Task.Delay(500);
            }
        }

        [RelayCommand]
        public Task PingAll()
        {
            return Task.CompletedTask;
        }
    }
}
