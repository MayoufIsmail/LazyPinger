using CommunityToolkit.Mvvm.ComponentModel;
using LazyPinger.Core.Models;
using System.Collections.ObjectModel;

namespace LazyPingerMAUI.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        [ObservableProperty]
        private ObservableCollection<DevicePing> detectedDevices = new();

        public MainViewModel()
        {
            InitDummyDevices();
        }

        private void InitDummyDevices()
        {
            DetectedDevices = new()
            {
                new DevicePing {
                    ID = 0, Description = "Dummy Device", IP = "192.168.0.1", MacAddress = "FF:FF:FF:FF", Name = "DummyDevice", Port = 50,
                },
                new DevicePing {
                    ID = 0, Description = "Dummy Device", IP = "192.168.0.1", MacAddress = "FF:FF:FF:FF", Name = "DummyDevice", Port = 50,
                },
                new DevicePing {
                    ID = 0, Description = "Dummy Device", IP = "192.168.0.1", MacAddress = "FF:FF:FF:FF", Name = "DummyDevice", Port = 50,
                }
            };
        }
    }
}
