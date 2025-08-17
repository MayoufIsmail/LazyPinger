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

        public VmDevicesGroup DeviceGroupTemp { get; set; }


        public SettingsViewModel(INetworkService networkService, MainViewModel mainViewModel)
        {
            MainVm = mainViewModel;
        }

        [RelayCommand]
        public async Task CreateNewDevice()
        {
            var db = ListenVm.Instance.dbContext;
            var newDevice = new DevicePing()
            {
                Name = DevicePingTemp.Name,
                DevicesGroup = DeviceGroupTemp.Entity,
                Image = DevicePingTemp.Image,
            };

            db.DevicePings.Add(newDevice);

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
            db.DevicesGroups.Add(DeviceGroupTemp.Entity);

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
