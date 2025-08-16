using CommunityToolkit.Mvvm.Input;
using LazyPinger.Base.Entities;
using LazyPinger.Base.IServices;
using LazyPinger.Core.ViewModels;

namespace LazyPingerMAUI.ViewModels
{
    public partial class SettingsViewModel : ViewModelBase
    {
        public MainViewModel MainVm { get; set; }

        public VmDevicePing VmDevicePingTemp { get; set; }

        public SettingsViewModel(INetworkService networkService, MainViewModel mainViewModel)
        {
            MainVm = mainViewModel;
        }

        [RelayCommand]
        public async Task ApplyUserSelection()
        {
            //ListenVm.Instance.UserSelections = new()
            //{
            //    IsFastPingDisabled = MainVm.UserSelection.IsFastPingDisabled,
            //    IsAutoRunDisabled = MainVm.UserSelection.IsAutoRunDisabled,
            //};

            var res = ListenVm.Instance.UserSelections.Entity;

            try
            {
                //ListenVm.Instance.dbContext.Update(res);

                await ListenVm.Instance.dbContext.SaveChangesAsync();
            }
            catch
            {

            }
        }
    }
}
