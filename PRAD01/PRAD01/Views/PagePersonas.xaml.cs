using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRAD01.Controllers;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PRAD01.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePersonas : ContentPage
    {
        public PagePersonas()
        {
            InitializeComponent();
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageControl());
        }

        private void ToolDelePersona_Clicked(object sender, EventArgs e)
        {

        }

        private void listapersonas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null)
            {
                Models.Personas persona = (Models.Personas)e.CurrentSelection.FirstOrDefault();
            }
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            listapersonas.ItemsSource = await DataBase.ObtenerListaPersonas();
        }

        private async void toolsitios_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageSitios());
        }

        private async void toolmap_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageListaSitios());
        }
    }
}