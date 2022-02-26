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
    public partial class PageEmple : ContentPage
    {
        public PageEmple()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {            
            await DisplayAlert("Alert", 
                  Convert.ToString(Convert.ToDouble(numero1.Text) + Convert.ToDouble(numero2.Text)) , 
                  "OK");
        }

        private async void btnresta_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert",
                 Convert.ToString(Convert.ToDouble(numero1.Text) - Convert.ToDouble(numero2.Text)),
                 "OK");
        }

        private async void btnmulti_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert",
                Convert.ToString(Convert.ToDouble(numero1.Text) * Convert.ToDouble(numero2.Text)),
                "OK");
        }

        private async void btndiv_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert",
                Convert.ToString(Convert.ToDouble(numero1.Text) / Convert.ToDouble(numero2.Text)),
                "OK");
        }
    }
}