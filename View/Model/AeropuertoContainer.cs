using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewAeropuerto.Model
{
    public static class AeropuertoContainer
    {
        public static List<Aeropuerto> aeropuertos = new();
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
        public static void BuildAeropuertoContainer()
        {
            for (int i = 0; i < 8; i++)
            {
                aeropuertos.Add(new Aeropuerto()
                {
                    Id = i,
                    Nombre = "Aeropuerto de "+lugares[i],
                    Lugar = lugares[i],
                    Descripcion = "Descripción"+i
                });
            }
        }
        public static void AddAeropuerto(Aeropuerto aeropuerto)
        {
            if (aeropuerto != null)
            {
                aeropuerto.Id = aeropuertos.Count;
                aeropuertos.Add(aeropuerto);
            }
        }
    }
}
