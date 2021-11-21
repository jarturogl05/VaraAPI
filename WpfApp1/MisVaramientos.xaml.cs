using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Net.Http;
using System.Net.Http.Headers;
using WpfApp1.Controller;
using Newtonsoft.Json.Linq;

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para MisVaramientos.xaml
    /// </summary>
    public partial class MisVaramientos : Window
    {
        public MisVaramientos()
        {
            GetVaramientos();
            InitializeComponent();
        }

        private void crearVaraBtn_Click(object sender, RoutedEventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Close();

        }

        private void GetVaramientos()
        {


            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://ec2-3-137-222-34.us-east-2.compute.amazonaws.com/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJmcmVzaCI6dHJ1ZSwiaWF0IjoxNjM3NDQ1ODkxLCJqdGkiOiIwYWRkMDczZC0yMWJmLTQxYzYtOWQzOS02M2QzZGVlOGZiNDYiLCJ0eXBlIjoiYWNjZXNzIiwic3ViIjoiZTU4ZWU4NTYtZjliYS00NDgwLTljZGEtNjFhZjdiMmQxYzVjIiwibmJmIjoxNjM3NDQ1ODkxLCJleHAiOjE2Mzc0Njc0OTF9.q0AHCGz4KiZOhIMRCzWqxEFu9YYlGS-zI4p54f_Qssg");
            HttpResponseMessage response = client.GetAsync("yo/varamientos").Result;
            MessageBox.Show(response.Content.ToString());

            if (response.IsSuccessStatusCode)
            {
                var jobject = JObject.Parse(response.ToString());

                var data = jobject["respuesta"];
                MessageBox.Show(data.ToString());


            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }



        }
    }
}
