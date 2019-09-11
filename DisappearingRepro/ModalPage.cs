using System.Diagnostics;
using Xamarin.Forms;

namespace DisappearingRepro
{
    public class ModalPage : ContentPage
    {
        public ModalPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Modal" }
                }
            };
        }

        protected override void OnDisappearing()
        {
            Debug.WriteLine("Modal OnDisappearing");
            base.OnDisappearing();
        }

        protected override void OnAppearing()
        {
            Debug.WriteLine("Modal OnAppearing");
            base.OnAppearing();
        }
    }
}