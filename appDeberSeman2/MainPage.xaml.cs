using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace appDeberSeman2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void txtNotaSegui1_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtNotaSegui1.Text))
            {
                if (Convert.ToDouble(txtNotaSegui1.Text) > 10)
                {
                    txtNotaParcial1.Text = "10";
                }
            }
        }

        private void txtNotaSegui2_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtNotaSegui2.Text))
            {
                if (Convert.ToDouble(txtNotaSegui2.Text) > 10)
                {
                    txtNotaParcial2.Text = "10";
                }
            }
        }

        private void txtExamen1_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtExamen1.Text))
            {
                if (Convert.ToDouble(txtExamen1.Text) > 10)
                {
                    txtExamen1.Text = "10";
                }
            }
        }

        private void txtExamen2_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtExamen2.Text))
            {
                if (Convert.ToDouble(txtExamen2.Text) > 10)
                {
                    txtExamen2.Text = "10";
                }
            }
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double notaParcial1 = (Convert.ToDouble(txtNotaSegui1.Text) * 0.30) + (Convert.ToDouble(txtExamen1.Text) * 0.20);
                double notaParcial2 = (Convert.ToDouble(txtNotaSegui2.Text) * 0.30) + (Convert.ToDouble(txtExamen2.Text) * 0.20);
                double resultado = notaParcial1 + notaParcial2;
                txtNotaParcial1.Text = Convert.ToString(notaParcial1);
                txtNotaParcial2.Text = Convert.ToString(notaParcial2);
                txtResultado.Text = Convert.ToString(resultado);
                if (resultado >= 7)
                {
                    txtEstado.Text = "APROBADO";
                    txtEstado.TextColor = Color.Green;
                }
                else if (resultado >= 5 && resultado <= 6.9)
                {
                    txtEstado.Text = "COMPLEMENTARIO";
                    txtEstado.TextColor = Color.Purple;
                }
                else if (resultado < 5)
                {
                    txtEstado.Text = "REPROBADO";
                    txtEstado.TextColor = Color.Red;
                }
            }
            catch (Exception)
            {
                DisplayAlert("ERROR","Se ha producido un erro al momento de cualcular","OK");
            }
            
        }
    }
}
