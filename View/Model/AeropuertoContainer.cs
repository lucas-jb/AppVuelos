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
        public static int aeropuertosCount = 0;
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
                var a = new Aeropuerto()
                {
                    Id = i,
                    Nombre = "Aeropuerto de "+lugares[i],
                    Lugar = lugares[i],
                    Descripcion = "Descripción"+i
                };
                AddAeropuerto(a);
            }
        }
        public static void AddAeropuerto(Aeropuerto aeropuerto)
        {
            if (aeropuerto != null)
            {
                aeropuerto.Id = aeropuertosCount;
                aeropuertos.Add(aeropuerto);
                aeropuertosCount++;
            }
        }
    }
}
