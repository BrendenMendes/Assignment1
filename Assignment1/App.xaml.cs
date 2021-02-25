using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Assignment1.Services;
using Assignment1.Views;

namespace Assignment1
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();

            MainPage = new NavigationPage(new LoginPage());

        }

        public void navigationMain(string to) {
            switch (to) {
                case "login":
                    MainPage = new NavigationPage(new LoginPage());
                    break;
                case "main":
                    MainPage = new MainPage();
                    break;
            }
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
