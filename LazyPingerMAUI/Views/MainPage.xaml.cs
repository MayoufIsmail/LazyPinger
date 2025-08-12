using LazyPinger.Base.IServices;
using LazyPinger.Core.Utils;
using LazyPingerMAUI.ViewModels;

namespace LazyPingerMAUI.Views
{
    public partial class MainPage : ContentPage
    {
        private INetworkService _networkService { get; set; }

        private MainViewModel _mainViewModel { get; set; }

        public MainPage(INetworkService networkService)
        {
            InitializeComponent();

            _networkService = networkService;
            _mainViewModel = new MainViewModel(networkService);

            this.BindingContext = _mainViewModel;

            Task.Run(async () => {
                await Task.Delay(_mainViewModel.AnimationHandler.WaitTimeToHideLogo);

                var tempAnimHandler = new AnimationHandler();
                tempAnimHandler.DevicesRowSpan = 2;
                tempAnimHandler.DevicesRow = 0;
                tempAnimHandler.IsTopLogoVisible = false;

                _mainViewModel.AnimationHandler = tempAnimHandler;
            });
        }
    }

}
