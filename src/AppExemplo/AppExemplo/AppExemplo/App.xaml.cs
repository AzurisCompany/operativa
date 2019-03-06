using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppExemplo.Services;
using AppExemplo.Views;
using Plugin.Settings;
using Plugin.Settings.Abstractions;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AppExemplo
{
    public partial class App : Application
    {
        //TODO: Replace with *.azurewebsites.net url after deploying backend to Azure
        public static string AzureBackendUrl = "http://localhost:5000";
        public static bool UseMockDataStore = true;

        public App()
        {
            InitializeComponent();

            if (UseMockDataStore)
                DependencyService.Register<MockDataStore>();
            else
                DependencyService.Register<AzureDataStore>();

            CrossSettings.Current.AddOrUpdateValue("IP", "10.1.1.14");
            var ip = CrossSettings.Current.GetValueOrDefault("IP","ip");

            MainPage = new MainPage();

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
