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
                await Task.Delay(_mainViewModel.AnimationHandler.WaitTimeSplashView);

                _mainViewModel.AnimationHandler = new AnimationHandler()
                {
                    IsSplashViewVisible = false,
                };

                await Task.Delay(_mainViewModel.AnimationHandler.WaitTimeToHideLogo);

                _mainViewModel.AnimationHandler = new AnimationHandler()
                {
                    DevicesRowSpan = 2,
                    DevicesRow = 0,
                    IsTopLogoVisible = false,
                    IsSplashViewVisible = false,
                };
            });
        }
    }

}
