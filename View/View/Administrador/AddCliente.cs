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

namespace View.View.Administrador
{
    public partial class AddCliente : Form
    {
        private int celselected = -1;
        public AddCliente()
        {
            InitializeComponent();
            CheckearCampos();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!RellenadoCheck())
            {
                MessageBox.Show("Faltan datos", "Cancelado");
            }
            else
            {
                Persona persona = new Persona()
                {
                    Nombre = textBoxName.Text,
                    Apellidos = textBoxSurname.Text,
                    Direccion = textBoxAdress.Text,
                    Dni = textBoxDni.Text
                };
                int cont = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[cont];
                row.Cells[0].Value = persona.Nombre;
                row.Cells[1].Value = persona.Apellidos;
                row.Cells[2].Value = persona.Direccion;
                row.Cells[3].Value = persona.Dni;

                ClearDatos();
            }
        }
        public bool CheckearCampos()
        {
            if (this.textBoxName.Text == string.Empty)
            {
                this.textBoxName.BackColor = Color.Red;
            }
            else
            {
                this.textBoxName.BackColor = Color.Green;
            }
            if (this.textBoxSurname.Text == string.Empty)
            {
                this.textBoxSurname.BackColor = Color.Red;
            }
            else
            {
                this.textBoxSurname.BackColor = Color.Green;
            }
            if (this.textBoxAdress.Text == string.Empty)
            {
                this.textBoxAdress.BackColor = Color.Red;
            }
            else
            {
                this.textBoxAdress.BackColor = Color.Green;
            }
            if (this.textBoxDni.Text == string.Empty)
            {
                this.textBoxDni.BackColor = Color.Red;
            }
            else
            {
                this.textBoxDni.BackColor = Color.Green;
            }
            return true;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            CheckearCampos();
        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {
            CheckearCampos();
        }

        private void textBoxAdress_TextChanged(object sender, EventArgs e)
        {
            CheckearCampos();
        }

        private void textBoxDni_TextChanged(object sender, EventArgs e)
        {
            CheckearCampos();
        }

        public void ClearDatos()
        {
            this.textBoxName.Text = string.Empty;
            this.textBoxSurname.Text = string.Empty;
            this.textBoxAdress.Text = string.Empty;
            this.textBoxDni.Text = string.Empty;
        }
        public bool RellenadoCheck()
        {
            if (this.textBoxName.Text != string.Empty && this.textBoxSurname.Text != string.Empty && this.textBoxAdress.Text != string.Empty && this.textBoxDni.Text != string.Empty)
            {
                return true;
            }
            return false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (celselected != -1 && dataGridView1.Rows.Count-1!=celselected)
            {
                dataGridView1.Rows.Remove(dataGridView1.Rows[celselected]);
                celselected = -1;
                dataGridView1.ClearSelection();
            }
            else
            {
                MessageBox.Show("No has seleccionado ninguna persona", "Cancelado");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            celselected = e.RowIndex;
        }
    }
}
