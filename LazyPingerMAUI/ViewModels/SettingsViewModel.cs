using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LazyPinger.Base.IServices;
using LazyPinger.Base.Models;
using System.Collections.ObjectModel;

namespace LazyPingerMAUI.ViewModels
{
    public partial class SettingsViewModel : ViewModelBase
    {
        [ObservableProperty]
        private ObservableCollection<DevicePing> detectedDevices = new();

        public SettingsViewModel(INetworkService networkService)
        {

        }
    }
}
