using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamStyledMenuPage.Views;

namespace XamStyledMenuPage
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MenuTabbedPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
