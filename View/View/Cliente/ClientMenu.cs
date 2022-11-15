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
        public ClientMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var menucompra = new Form1();
            menucompra.Show();
            this.Hide();
        }
    }
}
