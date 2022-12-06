using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstadisticasBillete.Model
{
    public static class PersonaContainer
    {
        public static List<Persona> personas = new List<Persona>();

        public static void BuildPersonaContainer()
        {
            for (int i = 0; i < 10; i++)
            {
                personas.Add(new Persona()
                {
                    Nombre = "Nombre" + i,
                    Apellidos = "Apellidos" + i,
                    Direccion = "Dorección" + i,
                    Dni = "dni" + i,
                    Nbilletes = i
                });
            }
        }

    }
}
