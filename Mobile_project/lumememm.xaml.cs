using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile_project
{
    using System;
    using Xamarin.Forms;

    namespace SnowmanApp
    {
        public partial class lumememm : ContentPage
        {
            AbsoluteLayout absoluteLayout;
            Label actionLabel;
            BoxView bucket;
            BoxView head;
            BoxView body;
            public lumememm()
            {
                absoluteLayout = new AbsoluteLayout();

                bucket = new BoxView
                {
                    Color = Color.Gray,
                    WidthRequest = 150,
                    HeightRequest = 200
                };
                head = new BoxView
                {
                    Color = Color.White,
                    WidthRequest = 100,
                    HeightRequest = 100
                };
                body = new BoxView
                {
                    Color = Color.White,
                    WidthRequest = 120,
                    HeightRequest = 120
                };

                absoluteLayout.Children.Add(bucket, new Rectangle(0.5, 0.1, 150, 200));
                absoluteLayout.Children.Add(head, new Rectangle(0.5, 0.4, 100, 100));
                absoluteLayout.Children.Add(body, new Rectangle(0.5, 0.6, 120, 120));

                Content = absoluteLayout;

                var buttonHide = new Button { Text = "Спрятать снеговика" };
                var buttonShow = new Button { Text = "Отобразить снеговика" };
                var buttonChangeColor = new Button { Text = "Раскрасить случайным цветом" };
                var buttonMelt = new Button { Text = "Растопить снеговика" };
                actionLabel = new Label { Text = "Выберите действие", HorizontalOptions = LayoutOptions.Center };

                buttonHide.Clicked += HideSnowman;
                buttonShow.Clicked += ShowSnowman;
                buttonChangeColor.Clicked += ChangeColor;
                buttonMelt.Clicked += MeltSnowman;

                var stackLayout = new StackLayout
                {
                    Children = { buttonHide, buttonShow, buttonChangeColor, buttonMelt, actionLabel },
                    VerticalOptions = LayoutOptions.EndAndExpand
                };

                absoluteLayout.Children.Add(stackLayout, new Rectangle(0.5, 0.9, 300, 200));
            }


            async void HideSnowman(object sender, EventArgs e)
            {
                absoluteLayout.IsVisible = false;
                actionLabel.Text = "Снеговик скрыт";
            }

            void ShowSnowman(object sender, EventArgs e)
            {
                absoluteLayout.IsVisible = true;
                actionLabel.Text = "Снеговик отображен";
            }

            async void ChangeColor(object sender, EventArgs e)
            {
                Random rnd = new Random();
                int r = rnd.Next(0, 255);
                int g = rnd.Next(0, 255);
                int b = rnd.Next(0, 255);

                bool result = await DisplayAlert("Изменение цвета",
                    $"Хотите изменить цвет на R:{r}, G:{g}, B:{b}?",
                    "Да", "Нет");

                if (result)
                {
                    absoluteLayout.BackgroundColor = Color.FromRgb(r, g, b);
                    actionLabel.Text = $"Цвет изменен на R:{r}, G:{g}, B:{b}";
                }
            }

            async void MeltSnowman(object sender, EventArgs e)
            {
                await System.Threading.Tasks.Task.Delay(1000);
                absoluteLayout.Children.Clear();
                actionLabel.Text = "Снеговик растаял";
            }
        }
    }
}
