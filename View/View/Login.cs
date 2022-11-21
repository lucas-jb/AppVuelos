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
        public static BilleteContainer billeteContainer = new BilleteContainer();
        public static PersonaContainer personaContainer = new PersonaContainer();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (personaContainer.Exists(textBoxUser.Text) && textBoxPass.Text == "1234")
            {
                var menu = new ClientMenu()
                {
                    clientDni = textBoxUser.Text
                };
                menu.Show();
                this.Hide();
            }else 
            if(textBoxUser.Text == "admin" && textBoxPass.Text == "1234")
            {
                var menu = new AdminMenu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Error");
            }
        }
    }
}
