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
using ViewAeropuerto.View.Cliente;

namespace ViewAeropuerto
{
    public partial class ComprarBillete : Form
    {
        public Vuelo? vueloIda = null;
        public Vuelo? vueloVuelta = null;
        private FormularioVuelo menu;
        public Persona user;

        public ComprarBillete(FormularioVuelo menu)
        {
            this.menu = menu;
            InitializeComponent();
        }
        public void Actualizar()
        {
            if (vueloVuelta != null)
            {
                this.textBoxOrigen.Text = vueloIda.Origen.Lugar;
                this.textBoxDestino.Text = vueloIda.Destino.Lugar;
                this.textBoxFI.Text = vueloIda.Fecha.ToString();
                this.textBoxFV.Text = vueloVuelta.Fecha.ToString();
            }
            else
            {
                this.textBoxOrigen.Text = vueloIda.Origen.Lugar;
                this.textBoxDestino.Text = vueloIda.Destino.Lugar;
                this.textBoxFI.Text = vueloIda.Fecha.ToString();
                this.textBoxFV.Text = "Viaje solo de ida.";
            }           
        }
        public void ClearDatos()
        {
            this.textBoxNombre.Text = menu.menu.user.Nombre;
            this.textBoxApellido.Text = menu.menu.user.Apellidos;
            this.textBoxDireccion.Text = menu.menu.user.Direccion;
            this.textBoxDNI.Text = menu.menu.user.Dni;
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
        public Billete GenerarBillete()
        {
            if (vueloIda != null)
            {
                return new Billete
                {
                    Pasajero = Damepersona(),
                    Ida = vueloIda,
                    Vuelta = vueloVuelta
                };
            }
            return new Billete();
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
                this.pictureBox1.Image = this.pictureBox1.ErrorImage;
            }
            else
            {
                this.pictureBox1.Image = this.pictureBox1.InitialImage;
            }
            if(this.textBoxApellido.Text == string.Empty)
            {
                this.pictureBox2.Image = this.pictureBox1.ErrorImage;
            }
            else
            {
                this.pictureBox2.Image = this.pictureBox1.InitialImage;
            }
            if (this.textBoxDireccion.Text == string.Empty)
            {
                this.pictureBox3.Image = this.pictureBox1.ErrorImage;
            }
            else
            {
                this.pictureBox3.Image = this.pictureBox1.InitialImage;
            }
            if (this.textBoxDNI.Text == string.Empty)
            {
                this.pictureBox4.Image = this.pictureBox1.ErrorImage;
            }
            else
            {
                this.pictureBox4.Image = this.pictureBox1.InitialImage;
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
                Billete billete = new Billete()
                {
                    Ida = vueloIda,
                    Vuelta = vueloVuelta,
                    Pasajero = menu.menu.user
                };
                BilleteContainer.AddBillete(billete);
                MessageBox.Show("Billenes comprados con éxito", "Comprado");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Faltan datos", "Cancelado");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }
    }
}
