using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Contactos.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace Contactos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactosPage : ContentPage
    {
        public ContactosPage()
        {
            InitializeComponent();
            CargarContactos();
        }

        private async Task CargarContactos()
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://192.168.1.65/TallerApis/");

            var request = await client.GetAsync("/api/Producto");
            if (request.IsSuccessStatusCode)
            {
                var responseJson = await request.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<List<Contacto>>(responseJson);
                listContactos.ItemsSource = response;
            }
        }

        private async void Contact_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            var contacto = e.SelectedItem as Contacto;
            await Navigation.PushAsync(new DetalleContatoPage(contacto));
        }
    }
}