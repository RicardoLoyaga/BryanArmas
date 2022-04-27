using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BryanArmas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string contrasena = txtPass.Text;
            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(contrasena))
            {
                if (usuario == "estudiante2022" && contrasena == "uisrael2022")
                {
                    await Navigation.PushAsync(new VistaNotas(usuario, contrasena));
                }
                else
                {
                    await DisplayAlert("Alerta! ", "Usuario/Contraseña incorrecta", "OK");
                }
            }
            else
            {
                await DisplayAlert("Alerta! ", "Usuario/Contraseña no puede ser vacia", "OK");
            }
        }
    }
}