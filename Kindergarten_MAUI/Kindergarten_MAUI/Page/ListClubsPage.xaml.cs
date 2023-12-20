using Android.Media.TV;
using System.Collections.Generic;
using System.Diagnostics;
using static Android.Icu.Text.AlphabeticIndex.Bucket;

namespace Kindergarten_MAUI
{
    public partial class ListClubsPage : ContentPage
    {
        private string _idParent;
        private List<Child> _childrens = new List<Child>();

        public ListClubsPage(string idParent)
        {
            InitializeComponent();

            _idParent = idParent;
            ChildClubGenerator();

            //InitializeComponent();
            //Title = "Modal";
            //Button backButton = new Button { Text = "Back", HorizontalOptions = LayoutOptions.Center };
            //Label label = new Label { Text = "Modal Message..." };
            ////  переход с модальной страницы назад
            //backButton.Clicked += async (o, e) => await Navigation.PopModalAsync();
            //Content = new StackLayout { Children = { label, backButton } };
        }

        private void ChildClubGenerator()
        {
            if (_idParent == "-1") // Генерируем тестовый набор
            {
                Child child_0 = new Child("Иванов Ваня", "0");
                Child.Club child_0_club_0 = new Child.Club("Рисование", "Петрова А.Д.", "13:40", true);
                Child.Club child_0_club_1 = new Child.Club("Пение", "Петрова А.Д.", "11:40", true);
                child_0.Clubs.Add(child_0_club_0);
                child_0.Clubs.Add(child_0_club_1);
                _childrens.Add(child_0);

                Child child_1 = new Child("Иванов Петя", "1");
                child_1.Clubs.Add(new Child.Club("Рисование", "Петрова А.Д.", "13:40", true));
                _childrens.Add(child_1);

                var children = ChilrenGenerate();

                Content = new StackLayout { Children = { children },
                    Margin = 10,
                    Spacing = 30,
                };
                Debug.WriteLine(_childrens.Count);
            }
            else
                Debug.WriteLine(_idParent); // TODO: Берём данные из БД
        }

        private VerticalStackLayout ChilrenGenerate()
        {
            Label childName_0 = new Label
            {
                Text = "Кружки на сегодня",
                TextColor = Color.Parse("Black"),
                FontSize = 24,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            VerticalStackLayout childrens = new VerticalStackLayout
            {
                Children = { childName_0 },
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Spacing = 30,
            };

            foreach (var child in _childrens)
            {
                childrens.Add(ClubsGenerate(child.Name, child.Clubs));
            }

            return childrens;
        }

        private VerticalStackLayout ClubsGenerate(string childName, List<Child.Club> clubs)
        {
            Label childName_0 = new Label
            {
                Text = childName,
                TextColor = Color.Parse("Black"),
                FontSize = 24,
                HorizontalOptions = LayoutOptions.StartAndExpand,
            };

            VerticalStackLayout children = new VerticalStackLayout
            {
                Children = { childName_0},
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Spacing = 30,
            };

            foreach (var club in clubs)
            {
                children.Children.Add(ClubGenerate(club));
            }
            return children;
        }

        private VerticalStackLayout ClubGenerate(Child.Club club)
        {
            // TODO: Вынести общие настройки
            Label labelTime = new Label { Text = club.Time, 
                TextColor = Color.Parse("Black"), 
                FontSize = 24, 
                HorizontalOptions = LayoutOptions.Start 
            };

            Label labelName = new Label { Text = club.Name, 
                TextColor = Color.Parse("Black"), 
                FontSize = 24,
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };

            Microsoft.Maui.Controls.Switch switcher = new Microsoft.Maui.Controls.Switch  
            { 
                IsToggled = true,
                ThumbColor = Color.Parse("#7196CD"),
                OnColor = Color.Parse("#2B313B"),
                HorizontalOptions = LayoutOptions.FillAndExpand,

            };
           // switcher.Toggled += switcher_Toggled;

            HorizontalStackLayout firstLine = new HorizontalStackLayout
            {
                Children = { labelTime, labelName, switcher },
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Spacing = 30,
                
            };
            
            Label labelTeacher = new Label { 
                Text = "Преп.:", 
                TextColor = Color.Parse("Black"),
                FontSize = 24,
                HorizontalOptions = LayoutOptions.Start
            };
            Label labelTeacherName = new Label 
            { 
                Text = club.Teacher, 
                TextColor = Color.Parse("Black"),
                FontSize = 24,
                HorizontalOptions = LayoutOptions.End
            };

            HorizontalStackLayout secondLine = new HorizontalStackLayout
            {
                Children = { labelTeacher, labelTeacherName },
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Spacing = 30
            };

            return new VerticalStackLayout { Children = { firstLine, secondLine }};
        }
    }
}