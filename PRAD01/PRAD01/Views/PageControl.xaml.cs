using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRAD01.Models;
using PRAD01.Controllers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PRAD01.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageControl : ContentPage
    {
        public PageControl()
        {
            InitializeComponent();
        }

        private void btnagregar_Clicked(object sender, EventArgs e)
        {
            var persona = new Personas
            {
                nombre = nombre.Text,
                apellido = apellido.Text,
                correo = correo.Text,
                fecha_nac = fecha_nac.Date,
                sexo = sexo.SelectedItem.ToString()
            };
            
            DataBase.AddPersona(persona);
        }
    }
}