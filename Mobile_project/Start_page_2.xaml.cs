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
    public partial class Start_page_2 : ContentPage
    {
        List<ContentPage> Pages = new List<ContentPage>()
        {
            new Entry_page(), new Time_page(), new ViewBox_page(), new date_time_page(), new Stepper_slider_page(), new lumememm()
        };
        List<string> texts = new List<string>()
        {
            "Entry leht", "Time leht", "ViewBox leht", "Clicker leht", "Date and time page", "Stepper and slider page", "Lumememm page"
        };
        StackLayout st;
        public Start_page_2()
        {
            st = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.Pink
            };
            for (int i = 0; i < Pages.Count; i++)
            {
                Button btn = new Button
                {
                    Text = texts[i],
                    BackgroundColor = Color.LightPink,
                    TextColor = Color.Black,
                    TabIndex = i
                };
                st.Children.Add(btn);
                btn.Clicked += Ava_vajav_leht;
            }
            ScrollView sv = new ScrollView();
            Content = sv;
        }
        private async void Ava_vajav_leht(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            await Navigation.PushAsync(Pages[button.TabIndex]);
        }
    }
}