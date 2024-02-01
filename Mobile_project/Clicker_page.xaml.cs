using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile_project
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Clicker_page : ContentPage
	{
        BoxView box;
        Label lbl;
        int score = 0;
        public Clicker_page()
        {
            InitializeComponent();
            int r = 0, g = 0, b = 0;
            lbl = new Label
            {
                Text = Convert.ToString(score),
                HorizontalOptions = LayoutOptions.Center,
                FontSize= 25,
            };
            box = new BoxView
            {
                Color = Color.FromRgb(r, g, b),
                CornerRadius = 10,
                WidthRequest = 200,
                HeightRequest = 400,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };
            Button Exit_button = new Button
            {
                Text = "Exit",
                BackgroundColor = Color.White,
                TextColor = Color.Black,
            };
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += tap_Tapped;
            box.GestureRecognizers.Add(tap);
            StackLayout st = new StackLayout { Children = { lbl, box, Exit_button } };
            Content = st;

            Exit_button.Clicked += Exit_button_Clicked;
        }
        Random rnd;
        private void tap_Tapped(object sender, EventArgs e)
        {
            rnd = new Random();
            box.Color = Color.FromRgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            score ++;
            lbl.Text = score.ToString();
        }
        private async void Exit_button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}