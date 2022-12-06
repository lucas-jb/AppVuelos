using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewAeropuerto.Model
{
    public class Vuelo
    {
        public Aeropuerto Origen { get; set; }
        public Aeropuerto Destino { get; set; }
        public DateTime Fecha { get; set; }

        public static List<string> lugares = new()
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
        public static Vuelo RandomVuelo(int i, bool pos)
        {
            if (pos)
            {
                return new Vuelo()
                {
                    Origen = AeropuertoContainer.aeropuertos[i],
                    Destino = i != 7 ? AeropuertoContainer.aeropuertos[i + 1] : AeropuertoContainer.aeropuertos[0],
                    Fecha = DateTime.Now
                };
            }
            else
            {
                return new Vuelo()
                {
                    Origen = i != 7 ? AeropuertoContainer.aeropuertos[i + 1] : AeropuertoContainer.aeropuertos[0],
                    Destino = AeropuertoContainer.aeropuertos[i],
                    Fecha = DateTime.Now
                };
            }
        }
        public static Vuelo DameVueloPorAeropuerto(string ida, string vuelta, DateTime fecha)
        {
            return new Vuelo()
            {
                Origen = AeropuertoContainer.BuscarNombre(ida),
                Destino = AeropuertoContainer.BuscarNombre(vuelta),
                Fecha = fecha
            };
        }
    }
}
