using PRAD01.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PRAD01.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListaSitios : ContentPage
    {
        public PageListaSitios()
        {
            InitializeComponent();
        }

        private  async void listasitios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null)
            {
                Models.Sitios sitio = (Models.Sitios)e.CurrentSelection.FirstOrDefault();

                var mappage = new Views.PageMaps();
                mappage.BindingContext = sitio;
                await Navigation.PushAsync(mappage);
            }

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            listasitios.ItemsSource = await SitiosController.ObtenerListaSitios();
        }
    }
}