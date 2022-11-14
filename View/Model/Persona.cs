using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    public class Persona
    {
        public string Nombre { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Dni { get; set; } = string.Empty;

        public string MostrarPersona()
        {
            return
                "Nombre: " + Nombre + Environment.NewLine +
                "Apellidos: " + Apellidos + Environment.NewLine +
                "Direccion: " + Direccion + Environment.NewLine +
                "Dni: " + Dni + Environment.NewLine;
        }
        
    }
}
