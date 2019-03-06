using System;
using DatabaseLib.IServices;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DatabaseLibORM.Model;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Appoperativa
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            // Criacao do banco 
            var db = DependencyService.Get<IDatabase>();
           db.CriarBanco();

            var dbOrm = new DatabaseLibORM.Service.DatabaseOrm();
            dbOrm.CriarBanco();
           


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
