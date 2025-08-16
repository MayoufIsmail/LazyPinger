using LazyPinger.Base.Entities;
using LazyPinger.Base.IServices;

namespace LazyPingerMAUI.ViewModels
{
    public partial class SettingsViewModel : ViewModelBase
    {
        public MainViewModel MainVm { get; set; }

        public SettingsViewModel(INetworkService networkService, MainViewModel mainViewModel)
        {
            MainVm = mainViewModel;
        }

        //partial void OnUserSelectionChanged(UserSelection newValue)
        //{
            
        //}
    }
}
