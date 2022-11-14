using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    public class Billete
    {
        public Persona Pasajero { get; set; }
        public Vuelo Ida { get; set; }
        public Vuelo? Vuelta { get; set; } = null;

        public string MostrarBillete()
        {
            if(Vuelta == null)
            {
            return
                "Datos pasajero: " + Environment.NewLine + Pasajero.MostrarPersona() +
                "Vuelo ida: " + Environment.NewLine + Ida.MostrarVuelo();
            }
            return
                "Datos pasajero: " + Environment.NewLine + Pasajero.MostrarPersona() +
                "Vuelo ida: " + Environment.NewLine + Ida.MostrarVuelo() +
                "Vuelo vuelta: " + Environment.NewLine + Vuelta.MostrarVuelo();
        }
    }
}
