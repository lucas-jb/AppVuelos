using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewAeropuerto.View.Administrador
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
            MessageBox.Show("Esta funcionalidad no está disponible en la versión de tu aplicación. Reinicia la App para ver las estadísticas de billetes.", "Error");
        }

        private void btnAeropuerto_Click(object sender, EventArgs e)
        {
            var addaeropuerto = new AeropuertoPanel(this);
            addaeropuerto.Show();
            this.Hide();
        }

        private void btnAeropuerto_Click_1(object sender, EventArgs e)
        {
            var addaeropuerto = new AeropuertoPanel(this);
            addaeropuerto.Show();
            this.Hide();
        }

        private void btnBilletes_Click(object sender, EventArgs e)
        {
            var billetePanel = new BilletePanel(this);
            billetePanel.Show();
            this.Hide();
        }
    }
}
