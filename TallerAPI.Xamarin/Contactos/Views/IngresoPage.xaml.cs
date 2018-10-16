using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contactos.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IngresoPage : ContentPage
	{
		public IngresoPage ()
		{
			InitializeComponent ();
		}

        private async void Button_Ingresar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactosPage());
        }
        private  void Button_Llamar(object sender, EventArgs e)
        {
            
        }
        private async void Button_Limpiar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactosPage());
        }
    }
}