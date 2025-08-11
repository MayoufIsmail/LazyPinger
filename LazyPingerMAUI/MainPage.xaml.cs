using LazyPingerMAUI.ViewModels;

namespace LazyPingerMAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new MainViewModel();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
           // SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
