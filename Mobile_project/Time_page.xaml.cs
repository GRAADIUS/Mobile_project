using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile_project
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Time_page : ContentPage
	{
		public Time_page ()
		{
			InitializeComponent ();
		}
        private async void TapGestureRecognizer_Tappened(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        bool flag = false;
        public async void NaitaAeg()
        {
            while (flag)
            {
                Time_run.Text = DateTime.Now.ToString("T");
                await Task.Delay(1000);
            }
        }

        private void Time_run_Clicked(object sender, EventArgs e)
        {
            if (flag)
            {
                flag= false;
            }
            else
            {
                flag = true;
                NaitaAeg();
            }
        }
    }
}