using Xamarin.Forms;

namespace DisappearingRepro
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
