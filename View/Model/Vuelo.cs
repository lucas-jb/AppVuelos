using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    public class Vuelo
    {
        public string Origen { get; set; } = string.Empty;
        public string Destino { get; set; } = string.Empty;
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
                "Origen: " + Origen + Environment.NewLine +
                "Destino: " + Destino + Environment.NewLine +
                "Fecha: " + Fecha.ToString() + Environment.NewLine;
        }

        public static Vuelo RandomVuelo()
        {
            Random rnd = new Random();
            int origen = rnd.Next(lugares.Count);
            int destino = rnd.Next(lugares.Count);
            return new Vuelo()
            {
                Origen = lugares[origen],
                Destino = lugares[destino],
                Fecha = DateTime.Now
            };
        }
    }
}
