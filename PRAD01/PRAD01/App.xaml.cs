using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PRAD01.Controllers;
using System.IO;
using PRAD01.Views;

namespace PRAD01
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DB.conexion(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DBPR.db3"));
            
            MainPage = new NavigationPage(new PagePersonas());
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
