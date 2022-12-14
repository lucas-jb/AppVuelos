using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewAeropuerto.Model;

namespace ViewAeropuerto.View.Cliente
{
    public partial class ClientMenu : Form
    {
        public string clientDni = string.Empty;
        private Login login;
        public Persona user;
        public ClientMenu(Login login, Persona user)
        {
            InitializeComponent();
            this.login = login;
            this.user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var menucompra = new FormularioVuelo(this);
            menucompra.Show();
            this.Hide();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            this.labelDatos.Text = BilleteContainer.BuscarDniToStringSoloId(clientDni);
            if(labelDatos.Text == string.Empty && labelDatos.Text != "El usuario no tiene billetes asociados.")
            {
                this.labelDatos.Text = "El usuario no tiene billetes asociados.";
            }
        }

        private void btnVerVuelo_Click(object sender, EventArgs e)
        {
            try
            {
                this.labelDatos.Text = BilleteContainer.BuscarDniAndIdToString(user.Dni, Int32.Parse(textBox1.Text));
            }
            catch
            {
                this.labelDatos.Text = "No existe el billete.";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();
        }
    }
}
