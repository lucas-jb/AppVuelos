using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    public class Billete
    {
        public Persona pasajero { get; set; }
        public Vuelo Ida { get; set; }
        public Vuelo Vuelta { get; set; }

        public string MostrarBillete()
        {
            return
                "Datos pasajero: " + pasajero.MostrarPersona() +
                "Vuelo ida: " + Ida.MostrarVuelo() + Environment.NewLine +
                "Vuelo vuelta: " + Vuelta.MostrarVuelo();

        }
    }
}
