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
    public partial class VistaNotas : ContentPage
    {
        public VistaNotas(string user, string pass)
        {
            InitializeComponent();
            lblUser.Text = "Bienvenido " + user + " código " + pass; 
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double factorCalculoNotas = 0.3;
            double factorCalculoExamen = 0.2;
            double notaSeguimiento1 = double.Parse(txtNotaSeguimiento1.Text);
            double notaSeguimiento2 = double.Parse(txtNotaSeguimiento2.Text);
            double notaExamen1 = double.Parse(txtNotaExamen1.Text);
            double notaExamen2 = double.Parse(txtNotaExamen2.Text);
            double notaParcial1 = (notaSeguimiento1 * factorCalculoNotas) + (notaExamen1 * factorCalculoExamen);
            double notaParcial2 = (notaSeguimiento2 * factorCalculoNotas) + (notaExamen2 * factorCalculoExamen);
            double notaFinal = notaParcial1 + notaParcial2;
            txtParcial1.Text = notaParcial1.ToString();
            txtParcial2.Text = notaParcial2.ToString();

            if (notaFinal >= 7 && notaFinal <=10)
            {
                DisplayAlert("Usted ha ","Aprobado la materia con "+ notaFinal,"OK");
            }
            else
            {
                DisplayAlert("Usted ha ", "Reprobado la materia con " +notaFinal, "OK");
            }


        }
    }
}