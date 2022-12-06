using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estadisticas
{
    public partial class Stats : Form
    {
        private Form menu;
        public Stats(Form menu)
        {
            this.menu = menu;
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }
    }
}
