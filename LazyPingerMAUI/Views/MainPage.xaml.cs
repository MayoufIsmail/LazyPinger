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
                await Task.Delay(_mainViewModel.AnimationHandler.WaitTimeToHideSplash);

                _mainViewModel.AnimationHandler = new AnimationHandler()
                {
                    IsSplashVisible = false,
                };

                await Task.Delay(_mainViewModel.AnimationHandler.WaitTimeToHideGrey);

                _mainViewModel.AnimationHandler = new AnimationHandler()
                {
                    IsGreyVisible = false,
                    IsSplashVisible = false,
                };

                await Task.Delay(_mainViewModel.AnimationHandler.WaitTimeToHideLogo);

                _mainViewModel.AnimationHandler = new AnimationHandler()
                {
                    DevicesRowSpan = 2,
                    DevicesRow = 0,
                    IsTopLogoVisible = false,
                    IsGreyVisible = false,
                    IsSplashVisible = false,
                };
            });
        }
    }

}
