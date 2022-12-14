using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewAeropuerto.Model
{
    public static class PersonaContainer
    {
        public static List<Persona> personas = new();

        public static void BuildPersonaContainer()
        {
            for (int i = 0; i < 8; i++)
            {
                var a = (new Persona()
                {
                    Nombre = "Nombre"+i,
                    Apellidos = "Apellidos"+i,
                    Direccion = "Dorección"+i,
                    Dni = "dni"+i,
                    Pass = generador_pass(8)
                });
                AddPersona(a);

                var b = (new Billete()
                {
                    Id = i,
                    Pasajero = personas[i],
                    Ida = Vuelo.RandomVuelo(i, true),
                    Vuelta = Vuelo.RandomVuelo(i, false)
                });
                BilleteContainer.AddBillete(b);

            }
            personas.Add(new Persona()
            {
                Nombre = "admin",
                Apellidos = "admin",
                Direccion = "admin",
                Dni = "admin",
                Pass = "admin",
                admin = true
            });
            personas.Add(new Persona()
            {
                Nombre = "user",
                Apellidos = "user",
                Direccion = "user",
                Dni = "user",
                Pass = "user"
            });
        }
        public static bool Exists(string dni)
        {
            if(personas.FirstOrDefault(persona => persona.Dni == dni) != null)
            {
                return true;
            }
            return false;
        }
        public static void AddPersona(Persona persona)
        {
            if (persona != null)
            {
                personas.Add(persona);
            }
        }
        public static Persona BuscarDni(string dni)
        {
            if (dni != null)
            {
                return personas.FirstOrDefault(persona => persona.Dni == dni) ?? new Persona();
            }
            return new Persona();
        }
        public static string generador_pass(int size)
        {
            var chars =
           "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[size];
            var random = new Random();
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            return (new String(stringChars));
        }
    }
}
