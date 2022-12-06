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
using ViewAeropuerto.View.Administrador;
using ViewAeropuerto.View.Cliente;

namespace ViewAeropuerto.View
{
    public partial class Login : Form
    {
        public Login()
        {
            AeropuertoContainer.BuildAeropuertoContainer();
            PersonaContainer.BuildPersonaContainer();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (PersonaContainer.BuscarDni(textBoxUser.Text).CheckPass(textBoxUser.Text, textBoxPass.Text))
            {
                if (PersonaContainer.BuscarDni(textBoxUser.Text).admin == false){
                    var menu = new ClientMenu(this, PersonaContainer.BuscarDni(textBoxUser.Text))
                    {
                        clientDni = textBoxUser.Text
                    };
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    var menu = new AdminMenu(this);
                    menu.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Error");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
