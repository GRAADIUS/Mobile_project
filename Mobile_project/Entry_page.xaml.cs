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
	public partial class Entry_page : ContentPage
	{
        Editor ed;
        Label lbl;
        public Entry_page ()
		{
			InitializeComponent ();
            Button Exit_button = new Button
            {
                Text = "Exit",
                BackgroundColor = Color.White,
                TextColor = Color.Black,
            };
            lbl = new Label
            {
                Text = "Peaceful text",
                BackgroundColor = Color.DeepPink,
                TextColor = Color.Black,
            };
            ed = new Editor
            {
                Placeholder = "Hi.",
                BackgroundColor = Color.HotPink,
                TextColor = Color.Black,
            };
            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.Pink,
                Children= {lbl, ed, Exit_button},
                VerticalOptions= LayoutOptions.FillAndExpand,
            };


            Content = st;
            Exit_button.Clicked += Exit_button_Clicked;
            ed.TextChanged += Editor_TextChanged;
        }
        private async void Exit_button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        private async void Editor_TextChanged(object sender, EventArgs e)
        {
            lbl.Text = ed.Text;
        }
    }
}