using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    public class Vuelo
    {
        public Aeropuerto Origen { get; set; }
        public Aeropuerto Destino { get; set; }
        public DateTime Fecha { get; set; }

        private static List<string> lugares = new()
        {
            "Dubái (EAU)",
            "Cancún (México)",
            "Estambul (Turquía)",
            "Nueva York (USA)",
            "Miami (USA)",
            "París (Francia)",
            "Doha (Qatar)",
            "Londres (Reino Unido)"
        };

        public string MostrarVuelo()
        {
            return
                "Origen: " + Origen.Lugar + Environment.NewLine +
                "Destino: " + Destino.Lugar + Environment.NewLine +
                "Fecha: " + Fecha.ToString() + Environment.NewLine;
        }
        private static Aeropuerto RandomAeropuerto()
        {
            Random rnd = new Random();
            int cant = rnd.Next(lugares.Count);

            return new Aeropuerto()
            {
                Id = AeropuertoContainer.aeropuertos.Count(),
                Nombre = lugares[cant],
                Descripcion = "Descripción."
            };
        }
        public static Vuelo RandomVuelo()
        {
            return new Vuelo()
            {
                Origen = RandomAeropuerto(),
                Destino = RandomAeropuerto(),
                Fecha = DateTime.Now
            };
        }
    }
}
