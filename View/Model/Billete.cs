using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewAeropuerto.Model
{
    public class Billete
    {
        public int Id { get; set; }
        public Persona Pasajero { get; set; }
        public Vuelo Ida { get; set; }
        public Vuelo Vuelta { get; set; } = new Vuelo() { Origen = new Aeropuerto() { Lugar = "Sin vuelta."} };

        public string MostrarBillete()
        {
            if(Vuelta == null)
            {
            return
                "Id del billete: " + Id.ToString() + Environment.NewLine +
                "Datos pasajero: " + Environment.NewLine + Pasajero.MostrarPersona() +
                "Vuelo ida: " + Environment.NewLine + Ida.MostrarVuelo();
            }
            return
                "Id del billete: " + Id.ToString() + Environment.NewLine +
                "Datos pasajero: " + Environment.NewLine + Pasajero.MostrarPersona() +
                "Vuelo ida: " + Environment.NewLine + Ida.MostrarVuelo() +
                "Vuelo vuelta: " + Environment.NewLine + Vuelta.MostrarVuelo();
        }

    }
}
