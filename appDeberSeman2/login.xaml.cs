using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appDeberSeman2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text.Equals("") || txtContrasenia.Text.Equals(""))
                {
                    await DisplayAlert("Aviso", "Usuario o contraseña vacíos.", "Cerrar");
                }
                else
                {
                    if (txtUsuario.Text.Equals("estudiante2022") || txtContrasenia.Text.Equals("uisrael2022"))
                    {
                        await Navigation.PushAsync(new MainPage());
                    }
                    else
                    {
                        await DisplayAlert("Aviso", "Usuario o contraseña incorrectos.", "Cerrar");
                    }
                }
            }
            catch (Exception)
            {

            }
           
        }
    }
}