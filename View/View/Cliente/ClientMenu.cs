using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.View.Cliente
{
    public partial class ClientMenu : Form
    {
        public string clientDni = string.Empty;
        private Login login;
        public ClientMenu(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var menucompra = new Form1(this);
            menucompra.Show();
            this.Hide();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            this.labelDatos.Text = Login.billeteContainer.BuscarDniToString(clientDni);
        }

        private void btnVerVuelo_Click(object sender, EventArgs e)
        {
            try
            {
                this.labelDatos.Text = Login.billeteContainer.BuscarIdToString(Int32.Parse(textBox1.Text));
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
