using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    public class PersonaContainer
    {
        public static List<Persona> personas = new();

        public PersonaContainer()
        {
            for (int i = 0; i < 10; i++)
            {
                personas.Add(new Persona()
                {
                    Nombre = "Nombre"+i,
                    Apellidos = "Apellidos"+i,
                    Direccion = "Dorección"+i,
                    Dni = "dni"+i
                });

                BilleteContainer.
                billetes.Add(new Billete()
                {
                    Pasajero = personas[i],
                    Ida = Vuelo.RandomVuelo(),
                    Vuelta = Vuelo.RandomVuelo()
                });
            }
        }
        public bool Exists(string dni)
        {
            if(personas.FirstOrDefault(persona => persona.Dni == dni) != null)
            {
                return true;
            }
            return false;
        }
        public void AddPersona(Persona persona)
        {
            if (persona != null)
            {
                personas.Add(persona);
            }
        }
        public Persona BuscarDni(string dni)
        {
            if (dni != null)
            {
                return personas.FirstOrDefault(persona => persona.Dni == dni) ?? new Persona();
            }
            return new Persona();
        }
    }
}
