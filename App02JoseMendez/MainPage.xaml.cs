using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App02JoseMendez
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string usuario, string contraseña)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario: " + usuario;
            lblContraseña.Text = contraseña;
        }
        
        

        private void btnVerificar_Clicked(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(txtValorS1.Text);
            double exam1 = Convert.ToDouble(txtValorE1.Text);
            double nota2 = Convert.ToDouble(txtValorS2.Text);
            double exam2 = Convert.ToDouble(txtValorE2.Text);
            
            try
            {
                if (nota1 >= 0 && nota1 < 10.1 && exam1 >= 0 && exam1 < 10.01)
                {
                    if (nota2 >= 0 && nota2 < 10.1 && exam2 >= 0 && exam2 < 10.01)
                    {
                        double seg1 = nota1 * 0.3;
                        double exa1 = exam1 * 0.2;
                        double sumapar1 = seg1 + exa1;
                        txtResultado1.Text = sumapar1.ToString();
                        //
                        double seg2 = nota2 * 0.3;
                        double exa2 = exam2 * 0.2;
                        double sumapar2 = seg2 + exa2;
                        txtResultado2.Text = sumapar2.ToString();

                        double notafin = sumapar1 + sumapar2;

                        if (notafin >= 7)
                        {
                            txtNotaFin.Text = notafin.ToString() + " APROBADO";
                        }
                        else if (notafin >= 5 && notafin <= 6.99)
                        {
                            txtNotaFin.Text = notafin.ToString() + " COMPLEMENTARIO";
                        }
                        else
                        {
                            txtNotaFin.Text = notafin.ToString() + " REPROBADO";
                        }
                    }
                    else
                    {
                        DisplayAlert("ERROR", "El " + nota2.ToString() + " sobrepasa el Valor", "ok");
                    }
                }
                else
                {
                    DisplayAlert("ERROR", "El " + nota1.ToString() + " sobrepasa el Valor", "ok");
                }

               

            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de Alerta", ex.Message, "ok");
            }
        }
    }
}
