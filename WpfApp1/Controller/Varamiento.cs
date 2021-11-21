using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Controller
{
    public class Varamiento
    {
        public Varamiento()
        {
        }

        public Varamiento(bool finalizado, string nombreInformante, string telefonoInformante, string direccioninformante, string ordenAnimal, string condicionAnimal, int numeroAnimales, string observaciones, bool facilAcceso, bool acantilado, string sustrato, string primeraVezVisto, string fechaAvistamiento, string pais, string estado, string ciudad, string localidad, string informacionAdicionalUbicacion, string latitud, string longitud)
        {
            this.finalizado = finalizado;
            this.nombreInformante = nombreInformante;
            this.telefonoInformante = telefonoInformante;
            this.direccioninformante = direccioninformante;
            this.ordenAnimal = ordenAnimal;
            this.condicionAnimal = condicionAnimal;
            this.numeroAnimales = numeroAnimales;
            this.observaciones = observaciones;
            this.facilAcceso = facilAcceso;
            this.acantilado = acantilado;
            this.sustrato = sustrato;
            this.primeraVezVisto = primeraVezVisto;
            this.fechaAvistamiento = fechaAvistamiento;
            this.pais = pais;
            this.estado = estado;
            this.ciudad = ciudad;
            this.localidad = localidad;
            this.informacionAdicionalUbicacion = informacionAdicionalUbicacion;
            this.latitud = latitud;
            this.longitud = longitud;
        }



        public string? uuid { get; set; } = null;
        public bool finalizado { get; set; } = false;
        public string nombreInformante { get; set; } = string.Empty;
        public string telefonoInformante { get; set; } = string.Empty;
        public string direccioninformante { get; set; } = string.Empty;
        public string ordenAnimal { get; set; } = string.Empty;
        public string condicionAnimal { get; set; } = string.Empty;
        public int numeroAnimales { get; set; } = 0;
        public string observaciones { get; set; } =  string.Empty;
        public bool facilAcceso { get; set; } = false;
        public bool acantilado { get; set; } = false;
        public string sustrato { get; set; } = string.Empty;
        public string primeraVezVisto { get; set; } = string.Empty;
        public string fechaAvistamiento { get; set; } = string.Empty;
        public string pais { get; set; } = string.Empty;
        public string estado { get; set; } = string.Empty;
        public string ciudad { get; set; } = string.Empty;
        public string localidad { get; set; } = string.Empty;
        public string informacionAdicionalUbicacion { get; set; } = string.Empty;
        public string latitud { get; set; } = string.Empty;
        public string longitud { get; set; } = string.Empty;

    }


  


}
