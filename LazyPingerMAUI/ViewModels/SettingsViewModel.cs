using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LazyPinger.Base.IServices;
using LazyPinger.Base.Models;
using LazyPinger.Core.Services;
using LazyPinger.Core.Utils;
using System.Collections.ObjectModel;

namespace LazyPingerMAUI.ViewModels
{
    public partial class SettingsViewModel : ViewModelBase
    {
        [ObservableProperty]
        private ObservableCollection<DevicePing> detectedDevices = new();

        [ObservableProperty]
        public UserSelection userSelection = new();

        public SettingsViewModel(INetworkService networkService)
        {

        }

        partial void OnUserSelectionChanged(UserSelection newValue)
        {
            
        }
    }
}
