using System.Diagnostics;

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

        private void OnSendLoginRequest(object sender, EventArgs e) => ToEntry(_logging.SendLoginRequest());
        private async void ToEntry(string idParent) => await Navigation.PushModalAsync(new ListClubsPage(idParent));
        private async void ToHelp(object? sender, EventArgs e) => await Navigation.PushModalAsync(new HelpPage());
    }
}