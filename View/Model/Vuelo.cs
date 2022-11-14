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

        public string MostrarVuelo()
        {
            return
                "Origen: " + Origen + Environment.NewLine +
                "Destino: " + Destino + Environment.NewLine +
                "Fecha: " + Fecha.ToString() + Environment.NewLine;
        }
    }
}
