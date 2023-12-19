using System.Windows.Input;

namespace Kindergarten_MAUI
{
    public partial class HelpPage : ContentPage
    {
        public HelpPage()
        {
            InitializeComponent();
            // TODO: добавить класс info  в который будем грузить почту, номер и другую инфу.
        }

        private async void Back(object sender, EventArgs e) => await Navigation.PopModalAsync();
        private async void CopyNumber(object sender, EventArgs e) => await Clipboard.Default.SetTextAsync("+7 (351) 262-67-36");
        private async void CopyEmail(object sender, EventArgs e) => await Clipboard.Default.SetTextAsync("garden123@mail.ru");
    }
}