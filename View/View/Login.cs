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
using View.View.Administrador;
using View.View.Cliente;

namespace View.View
{
    public partial class Login : Form
    {
        public Login()
        {
            PersonaContainer.BuildPersonaContainer();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (PersonaContainer.BuscarDni(textBoxUser.Text).CheckPass(textBoxUser.Text, textBoxPass.Text))
            {
                if (PersonaContainer.BuscarDni(textBoxUser.Text).admin == false){
                    var menu = new ClientMenu(this)
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
    }
}
