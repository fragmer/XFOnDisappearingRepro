using System.Diagnostics;
using Xamarin.Forms;

namespace DisappearingRepro
{
    public class ChildPage : ContentPage
    {
        public ChildPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Child Page" }
                }
            };
        }

        /// <inheritdoc />
        protected override void OnDisappearing()
        {
            Debug.WriteLine("ChildPage OnDisappearing");
            base.OnDisappearing();
        }

        /// <inheritdoc />
        protected override bool OnBackButtonPressed()
        {
            Debug.WriteLine("ChildPage OnBackButtonPressed");
            return base.OnBackButtonPressed();
        }

        /// <inheritdoc />
        protected override void OnAppearing()
        {
            Debug.WriteLine("ChildPage OnAppearing");
            base.OnAppearing();
        }
    }
}