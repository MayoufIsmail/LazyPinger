using LazyPinger.Base.IServices;
using LazyPingerMAUI.ViewModels;

namespace LazyPingerMAUI.Views
{
    public partial class MainPage : ContentPage
    {
        private INetworkService _networkService { get; set; }

        public MainPage(INetworkService networkService)
        {
            InitializeComponent();
            _networkService = networkService;
            this.BindingContext = new MainViewModel(networkService);
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
           // SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
