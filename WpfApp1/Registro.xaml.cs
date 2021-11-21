using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Controller;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Registro : Window
    {
        public Registro()
        {
            InitializeComponent();
        }

        bool facilAccesso = false;
        bool acantilado = false;
        private void regresarBtn_Click(object sender, RoutedEventArgs e)
        {
            MisVaramientos misVaramientos = new MisVaramientos();
            misVaramientos.Show();
            this.Close();
        }

        private void Postvaramiento()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://ec2-3-137-222-34.us-east-2.compute.amazonaws.com");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJmcmVzaCI6dHJ1ZSwiaWF0IjoxNjM3NDQ1ODkxLCJqdGkiOiIwYWRkMDczZC0yMWJmLTQxYzYtOWQzOS02M2QzZGVlOGZiNDYiLCJ0eXBlIjoiYWNjZXNzIiwic3ViIjoiZTU4ZWU4NTYtZjliYS00NDgwLTljZGEtNjFhZjdiMmQxYzVjIiwibmJmIjoxNjM3NDQ1ODkxLCJleHAiOjE2Mzc0Njc0OTF9.q0AHCGz4KiZOhIMRCzWqxEFu9YYlGS-zI4p54f_Qssg");

            var varamiento = new Varamiento
            {
                finalizado = false,
                nombreInformante = infoNomTb.Text,
                telefonoInformante = infoTelTb.Text,
                direccioninformante = infoDireccionTb.Text,
                ordenAnimal = ordenAnimalCb.Text,
                condicionAnimal = condicionAnimalCb.Text,
                numeroAnimales = Int32.Parse(numAnimalesTb.Text),
                observaciones = observacionesTb.Text,
                facilAcceso = facilAccesso,
                acantilado = acantilado,
                sustrato = sustratoCb.Text,
                primeraVezVisto = primeraVistoCb.Text,
                fechaAvistamiento = fechaAvistamientoCb.Text,
                pais = paisTb.Text,
                estado = estadoTb.Text,
                ciudad = ciudadTb.Text,
                localidad = localidadTb.Text,
                informacionAdicionalUbicacion = infoAdicionalTb.Text,
                latitud = latitudTb.Text,
                longitud = longitudTb.Text
            };



            var response = client.PostAsJsonAsync("/yo/varamientos", varamiento).Result;



            if (response.IsSuccessStatusCode)

            {

                MessageBox.Show("Varamiento registrado");

                this.Close();

            }

            else

            {

                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);

            }
        }

        private void facilAcChb_Checked(object sender, RoutedEventArgs e)
        {
            if(facilAcChb.IsChecked == true)
            {
                facilAccesso = true;
            }
            else
            {
                facilAccesso = false;
            }
          
        }

        private void acantiladoChb_Checked(object sender, RoutedEventArgs e)
        {
            if (acantiladoChb.IsChecked == true)
            {
                acantilado = true;
            }
            else
            {
                acantilado = false;
            }

        }

        private void guardarBtn_Click(object sender, RoutedEventArgs e)
        {
            Postvaramiento();
        }
    }
}
