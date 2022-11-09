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

namespace View
{
    public partial class Form2 : Form
    {
        public string origen { get; set; }
        public string destino { get; set; }
        public string fechaIda { get; set; }
        public string fechaVuelta { get; set; }

        public Form2()
        {
            InitializeComponent();
        }
        public void Actualizar()
        {
            this.textBoxOrigen.Text = origen;
            this.textBoxDestino.Text = destino;
            this.textBoxFI.Text = fechaIda;
            this.textBoxFV.Text = fechaVuelta;
        }
        public void ClearDatos()
        {
            this.textBoxNombre.Text = string.Empty;
            this.textBoxApellido.Text = string.Empty;
            this.textBoxDireccion.Text = string.Empty;
            this.textBoxDNI.Text = string.Empty;
        }
        public string DameDatos()
        {
            return
            "Nombre: " + textBoxNombre.Text + Environment.NewLine +
            "Apellido: " + textBoxApellido.Text + Environment.NewLine +
            "Direccion: " + textBoxDireccion.Text + Environment.NewLine +
            "DNI: " + textBoxDNI.Text;
        }
        public Persona Damepersona()
        {
            return new Persona()
            {
                Nombre = textBoxNombre.Text,
                Apellidos = textBoxApellido.Text,
                Direccion = textBoxDireccion.Text,
                Dni = textBoxDNI.Text

            } ?? new Persona();
        }
        public bool RellenadoCheck()
        {
            if(this.textBoxNombre.Text != string.Empty && this.textBoxApellido.Text != string.Empty && this.textBoxDireccion.Text != string.Empty && this.textBoxDNI.Text != string.Empty)
            {
                return true;
            }
            return false;
        }
        public bool CheckearCampos()
        {
            if (this.textBoxNombre.Text == string.Empty)
            {
                this.textBoxNombre.BackColor = Color.Red;
            }
            else
            {
                this.textBoxNombre.BackColor = Color.Green;
            }
            if(this.textBoxApellido.Text == string.Empty)
            {
                this.textBoxApellido.BackColor = Color.Red;
            }
            else
            {
                this.textBoxApellido.BackColor = Color.Green;
            }
            if (this.textBoxDireccion.Text == string.Empty)
            {
                this.textBoxDireccion.BackColor = Color.Red;
            }
            else
            {
                this.textBoxDireccion.BackColor = Color.Green;
            }
            if (this.textBoxDNI.Text == string.Empty)
            {
                this.textBoxDNI.BackColor = Color.Red;
            }
            else
            {
                this.textBoxDNI.BackColor = Color.Green;
            }
            return true;
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            CheckearCampos();
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            CheckearCampos();
        }

        private void textBoxDireccion_TextChanged(object sender, EventArgs e)
        {
            CheckearCampos();
        }

        private void textBoxDNI_TextChanged(object sender, EventArgs e)
        {
            CheckearCampos();
        }

        private void btCompra_Click(object sender, EventArgs e)
        {
            if (RellenadoCheck())
            {
                MessageBox.Show("Billenes comprados con éxito", "Comprado");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Faltan datos", "Cancelado");
            }

        }
    }
}
