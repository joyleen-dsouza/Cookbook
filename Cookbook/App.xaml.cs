using Cookbook.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cookbook
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Receipeview());
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
