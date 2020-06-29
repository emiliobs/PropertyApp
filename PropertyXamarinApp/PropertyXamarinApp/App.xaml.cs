using Plugin.SharedTransitions;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("NunitoSans-Bold.ttf", Alias = "ThemeFontRegular")]
[assembly: ExportFont("NunitoSans-Regular.ttf", Alias = "ThemeFontMedium")]
[assembly: ExportFont("NunitoSans-SemiBold.ttf", Alias = "ThemeFontBold")]
namespace PropertyXamarinApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SharedTransitionNavigationPage(new MainPage());
            //MainPage = new NavigationPage(new MainPage());
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
