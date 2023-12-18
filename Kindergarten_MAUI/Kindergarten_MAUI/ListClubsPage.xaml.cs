namespace Kindergarten_MAUI
{
    public partial class ListClubsPage : ContentPage
    {
        public ListClubsPage()
        {
            Title = "Modal";
            Button backButton = new Button { Text = "Back", HorizontalOptions = LayoutOptions.Start };
            Label label = new Label { Text = "Modal Message..." };
            //  переход с модальной страницы назад
            backButton.Clicked += async (o, e) => await Navigation.PopModalAsync();
            Content = new StackLayout { Children = { label, backButton } };
        }
    }
}