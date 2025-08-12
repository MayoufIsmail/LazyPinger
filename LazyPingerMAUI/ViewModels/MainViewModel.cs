using CommunityToolkit.Mvvm.ComponentModel;
using LazyPinger.Base.Models;
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
            var temp = new DevicePing
            {
                ID = 0,
                Description = "Dummy Device",
                IP = "192.168.0.1",
                MacAddress = "FF:FF:FF:FF",
                Name = "DummyDevice",
                Port = 50,
            };

            for (int i = 0; i < 2; i++) {
                DetectedDevices.Add(temp);
            }
        }
    }
}
