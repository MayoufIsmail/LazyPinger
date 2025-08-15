using CommunityToolkit.Mvvm.ComponentModel;
using LazyPingerMAUI.ViewModels;

namespace LazyPinger.Core.Utils
{
    public partial class UserSelection : ViewModelBase
    {
        public int ID {  get; set; }

        public string Name { get; set; }

        [ObservableProperty]
        public bool isAutoRunDisabled = false;

        [ObservableProperty]
        public bool isFastPingDisabled = true;
    }
}
