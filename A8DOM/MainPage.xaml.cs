using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Data;


namespace A8DOM
{
    public partial class MainPage : ContentPage
    {
        private int status_actual = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        void Click_Numero(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            string intnumero = boton.Text;
            screen.Text += intnumero;
        }

        void Click_Limpia(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            screen.Text = "";
        }

        void Click_Resultado(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            try
            {
                var formula = screen.Text;
                double result = Convert.ToDouble(new DataTable().Compute(formula, null));
                screen.Text = "";
                screen.Text = result.ToString();
            }
            catch (Exception ex)
            {
                screen.Text = ex.Message;
            }
            
        }

        void Click_Operador(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            var operador = boton.Text;
            screen.Text += operador;
        }

        async Task<int> Calcula(string cadena)
        {
            

            

            return 1;
        }

    }
}
