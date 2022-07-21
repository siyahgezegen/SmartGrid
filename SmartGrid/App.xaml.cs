using SmartGrid.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartGrid
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SmartGridPage();
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
