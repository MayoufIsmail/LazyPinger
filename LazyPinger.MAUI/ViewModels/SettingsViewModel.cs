using CommunityToolkit.Mvvm.Input;
using LazyPinger.Base.Entities;
using LazyPinger.Base.IServices;
using LazyPinger.Base.Models.Devices;
using LazyPinger.Core.ViewModels;

namespace LazyPingerMAUI.ViewModels
{
    public partial class SettingsViewModel : ViewModelBase
    {
        public MainViewModel MainVm { get; set; }

        public DevicePing DevicePingTemp { get; set; } = new();

        public DevicesGroup DeviceGroupTemp { get; set; } = new();

        public SettingsViewModel(INetworkService networkService, MainViewModel mainViewModel)
        {
            MainVm = mainViewModel;
        }

        [RelayCommand]
        public async Task CreateNewDevice()
        {
            var db = ListenVm.Instance.dbContext;
            db.DevicePings.Add(DevicePingTemp);

            try
            {
                await db.SaveChangesAsync();
            }

            catch (Exception ex) {

            }
        }

        [RelayCommand]
        public async Task CreateNewDeviceGroup()
        {
            var db = ListenVm.Instance.dbContext;
            db.DevicesGroups.Add(DeviceGroupTemp);

            try
            {
                await db.SaveChangesAsync();
            }

            catch (Exception ex)
            {

            }
        }


        [RelayCommand]
        public async Task ApplyUserSelection()
        {
            var res = ListenVm.Instance.UserSelections.Entity;

            try
            {
                await ListenVm.Instance.dbContext.SaveChangesAsync();
            }
            catch
            {

            }
        }
    }
}
