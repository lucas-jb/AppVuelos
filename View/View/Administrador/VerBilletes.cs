using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Model;

namespace View.View.Administrador
{
    public partial class VerBilletes : Form
    {
        private AdminMenu menu;
        public VerBilletes(AdminMenu menu)
        {
            this.menu = menu;
            InitializeComponent();
        }
        private void Ver_billetes_Load(object sender, EventArgs e)
        {
            //foreach (Persona p in PersonaContainer.personas)
            //{
            //    var s = ; //= Grafico.Series.Add(p.Dni);
            //    s.Label = p.Dni;
            //    s.Points.Add(BilleteContainer.BuscarDni(p.Dni));
            //}
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }
    }
}
