using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.View.Administrador
{
    public partial class AdminMenu : Form
    {
        private Login login;
        public AdminMenu(Login login)
        {
            this.login = login;
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var addcliente = new AddCliente(this);
            addcliente.Show();
            this.Hide();
        }

        private void btnVerBilletes_Click(object sender, EventArgs e)
        {
            var verbilletes = new VerBilletes(this);
            verbilletes.Show();
            this.Hide();
        }
    }
}
