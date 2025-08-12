using LazyPinger.Base.IServices;
using LazyPingerMAUI.ViewModels;

namespace LazyPingerMAUI.Views
{
    public partial class SettingsPage : ContentPage
    {
        private INetworkService _networkService { get; set; }

        public SettingsPage(INetworkService networkService)
        {
            InitializeComponent();
            _networkService = networkService;
            //this.BindingContext = new MainViewModel(networkService);
        }
    }

}
