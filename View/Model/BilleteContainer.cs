using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewAeropuerto.Model
{
    public static class BilleteContainer
    {
        public static List<Billete> billetes = new();

        public static bool Exists(int id)
        {
            if (billetes.FirstOrDefault(billete => billete.Id == id) != null)
            {
                return true;
            }
            return false;
        }
        public static bool ModificarBillete(Billete billete)
        {
            if (Exists(billete.Id))
            {
                billetes.Remove(BuscarId(billete.Id));
                billetes.Add(billete);
                return true;
            }
            return false;
        }
        public static Billete BuscarId(int id)
        {
            if (id > 0)
            {
                return billetes.FirstOrDefault(billete => billete.Id == id) ?? new Billete();
            }
            return new Billete();
        }
        public static string BuscarIdToString(int id)
        {
            if (id > 0 && Exists(id))
            {
                return billetes.FirstOrDefault(billete => billete.Id == id).MostrarBillete();
            }
            return "No existe el billete.";
        }
        public static List<Billete> BuscarDni(string dni)
        {
            if (dni != null)
            {
                return billetes.FindAll(billete => billete.Pasajero.Dni == dni) ?? new List<Billete>();
            }
            return new List<Billete>();
        }

        public static string BuscarDniToString(string dni)
        {
            List<Billete> billetes = BuscarDni(dni);
            string text = string.Empty;
            if(billetes != null)
            {
                foreach (Billete billete in billetes)
                {
                    text = text + billete.MostrarBillete() + Environment.NewLine;
                }
            }
            return text;
        }

        public static void AddBillete(Billete billete)
        {
            if (billete != null)
            {
                billete.Id = billetes.Count;
                billetes.Add(billete);
            }
        }
        public static bool DeleteBillete(int id)
        {
            if (Exists(id))
            {
                billetes.Remove(BuscarId(id));
                return true;
            }
            return false;
        }
    }
}
