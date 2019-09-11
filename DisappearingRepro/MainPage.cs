using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DisappearingRepro
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            var button = new Button { Text = "Go to child page" };
            button.Clicked += Button_OnClicked;

            Content = new StackLayout
            {
                Children = {
                    button
                }
            };
        }

        protected override void OnAppearing()
        {
            Debug.WriteLine("MainPage OnAppearing");
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            Debug.WriteLine("MainPage OnDisappearing");
            base.OnDisappearing();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ModalPage(), false);
            // await Task.Delay(100); // Uncomment to test a workaround
            await Navigation.PopModalAsync(false);
            await Navigation.PushAsync(new ChildPage(), true);
        }
    }
}