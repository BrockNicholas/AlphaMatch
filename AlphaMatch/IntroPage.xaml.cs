using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AlphaMatch
{
    public partial class IntroPage : ContentPage
    {
        public IntroPage()
        {
            InitializeComponent();
            BackgroundImage = "bg.jpg";

            six.Clicked += Six_Clicked;
            eight.Clicked += Eight_Clicked;
            twelve.Clicked += Twelve_Clicked;
        }

        private void Six_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage(6));
        }

        private void Eight_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage(8));
        }

        private void Twelve_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage(12));
        }

        

        
    }
}
