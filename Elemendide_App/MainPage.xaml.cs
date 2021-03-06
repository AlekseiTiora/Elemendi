using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Elemendide_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //InitializeComponent();
            StackLayout st = new StackLayout();
            Button Ent_btn = new Button()
            {
                Text = "Entry",
                BackgroundColor = Color.LightCoral,
            };

            Button Timer_btn = new Button()
            {
                Text = "Timer",
                BackgroundColor = Color.LightCoral,
            };
            Button cliker = new Button()
            {
                Text = "Clicker",
                BackgroundColor = Color.LightCoral,
            };

            Button Date_btn = new Button
            {
                Text = "Date/Time",
                BackgroundColor = Color.LightCoral,
            };

            Button SS_btn = new Button
            {
                Text = "Stepper/Slider",
                BackgroundColor = Color.LightCoral,
            };
            Button frame_btn = new Button
            {
                Text = "Frame",
                BackgroundColor = Color.LightCoral,
            };
            Button image_btn = new Button
            {
                Text = "image",
                BackgroundColor = Color.LightCoral,
            };
            Button svet_btn = new Button
            {
                Text = "valgusfoor",
                BackgroundColor = Color.LightCoral,
            };


            st.Children.Add(Ent_btn);
            st.Children.Add(Timer_btn);
            st.Children.Add(cliker);
            st.Children.Add(Date_btn);
            st.Children.Add(SS_btn);
            st.Children.Add(frame_btn);
            st.Children.Add(image_btn);
            st.Children.Add(svet_btn);
            st.BackgroundColor = Color.AntiqueWhite;
            Content = st;
            Ent_btn.Clicked += Ent_btn_Clicked;
            Timer_btn.Clicked += Timer_btn_Clicked;
            cliker.Clicked += Cliker_Clicked;
            Date_btn.Clicked += Date_btn_Clicked;
            SS_btn.Clicked += SS_btn_Clicked;
            frame_btn.Clicked += Frame_btn_Clicked;
            image_btn.Clicked += Image_btn_Clicked;
            svet_btn.Clicked += Svet_btn_Clicked;
        }

        private async void Svet_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Valgusfoor());
        }

        private async void Image_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Image_Page());
        }

        private async void Frame_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Frame_Page());
        }

        private async void SS_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StepperSlider_Page());
        }

        private async void Date_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DateTime_Page());
        }

        private async void Cliker_Clicked(object sender, EventArgs e)
        {
             await Navigation.PushAsync(new cliker());
        }

        private async void Timer_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TimerPage());
        }

        private async void Ent_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ent_page());
        }
    }
    
}
