using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    public class BilleteContainer
    {
        public static List<Billete> billetes = new();

        public Billete BuscarId(int id)
        {
            if (id > 0)
            {
                return billetes.FirstOrDefault(billete => billete.Id == id) ?? new Billete();
            }
            return new Billete();
        }
        public List<Billete> BuscarDni(string dni)
        {
            if (dni != null)
            {
                return billetes.FindAll(billete => billete.Pasajero.Dni == dni) ?? new List<Billete>();
            }
            return new List<Billete>();
        }

        public String BuscarDniToString(string dni)
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

        public void AddBillete(Billete billete)
        {
            if (billete != null)
            {
                billetes.Add(billete);
            }
        }
    }
}
