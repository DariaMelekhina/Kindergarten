namespace Kindergarten_MAUI
{
    public partial class MainPage : ContentPage
    {
        Logging _logging;
        public MainPage()
        {
            _logging = new Logging();
            InitializeComponent();
        }

        public void OnSetPassword(object sender, TextChangedEventArgs e) => _logging.SetPassword(e.NewTextValue);
        public void OnSetLogin(object sender, TextChangedEventArgs e) => _logging.SetLogin(e.NewTextValue);

        private void OnSendLoginRequest(object sender, EventArgs e)
        {
            bool isLogin = _logging.SendLoginRequest();

            if (isLogin)
                ToEntry(sender, e);
            //SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private async void ToEntry(object? sender, EventArgs e) => await Navigation.PushModalAsync(new ListClubsPage());
        private async void ToHelp(object? sender, EventArgs e) => await Navigation.PushModalAsync(new HelpPage());
    }
}