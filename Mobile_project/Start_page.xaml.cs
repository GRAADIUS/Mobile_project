using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile_project
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Start_page : ContentPage
	{
		public Start_page ()
		{
            Button Entry_button = new Button
            {
                Text = "Entry leht",
                BackgroundColor = Color.White,
                TextColor = Color.Black,
            };
            Button Time_button = new Button
            {
                Text = "Time leht",
                BackgroundColor = Color.White,
                TextColor = Color.Black,
            };
            Button Clicker_button = new Button
            {
                Text = "Clicker leht",
                BackgroundColor = Color.White,
                TextColor = Color.Black,
            }; 
            Button BV_button = new Button
            {
                Text = "BoxView leht",
                BackgroundColor = Color.White,
                TextColor = Color.Black,
            };
            StackLayout st = new StackLayout
			{
				Orientation = StackOrientation.Vertical,
				BackgroundColor = Color.Pink,

			};
            st.Children.Add(Entry_button);
            st.Children.Add(Time_button);
            st.Children.Add(Clicker_button);
            st.Children.Add(BV_button);
            Content = st;
            Entry_button.Clicked += Entry_button_Clicked;
            Time_button.Clicked += Time_button_Clicked;
            Clicker_button.Clicked += Clicker_button_Clicked;
            BV_button.Clicked += BV_button_Clicked;
        }
        private async void Entry_button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Entry_page());
        }
        private async void Time_button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Time_page());
        }
        private async void Clicker_button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Clicker_page());
        }
        private async void BV_button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewBox_page());
        }

    }
}