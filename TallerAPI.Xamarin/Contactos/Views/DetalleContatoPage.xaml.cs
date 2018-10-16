using Contactos.Models;
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
	public partial class DetalleContatoPage : ContentPage
	{
		public DetalleContatoPage (Contacto contacto)
		{
			InitializeComponent ();
            BindingContext = contacto;
		}
	}
}