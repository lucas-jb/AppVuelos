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
        private AdminMenu menu;
        BindingSource bs = new BindingSource();
        public AddCliente(AdminMenu menu)
        {
            this.menu = menu;
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
                PersonaContainer.personas.Add(persona);
                MostrarClientes();
                ClearDatos();
            }
        }
        public bool CheckearCampos()
        {
            if (this.textBoxName.Text == string.Empty)
            {
                this.pictureBox1.Image = this.pictureBox1.ErrorImage;
            }
            else
            {
                this.pictureBox1.Image = this.pictureBox1.InitialImage;
            }
            if (this.textBoxSurname.Text == string.Empty)
            {
                this.pictureBox2.Image = this.pictureBox1.ErrorImage;
            }
            else
            {
                this.pictureBox2.Image = this.pictureBox1.InitialImage;
            }
            if (this.textBoxAdress.Text == string.Empty)
            {
                this.pictureBox3.Image = this.pictureBox1.ErrorImage;
            }
            else
            {
                this.pictureBox3.Image = this.pictureBox1.InitialImage;
            }
            if (this.textBoxDni.Text == string.Empty)
            {
                this.pictureBox4.Image = this.pictureBox1.ErrorImage;
            }
            else
            {
                this.pictureBox4.Image = this.pictureBox1.InitialImage;
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
                int index = dataGridView1.SelectedCells[0].RowIndex;
                string? dni = dataGridView1.Rows[index].Cells[3].Value.ToString();

                if (BilleteContainer.BuscarDni(dni).Count > 0)
                {
                    MessageBoxButtons botones = MessageBoxButtons.YesNo;
                    string cuerpo = "Este usuario tiene billetes asociados. ¿Eliminar aún así?";
                    string cabecera = "ATENCIÓN";
                    DialogResult resultado = MessageBox.Show(cuerpo, cabecera, botones);
                    if (resultado == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Remove(dataGridView1.Rows[celselected]);
                        celselected = -1;
                        dataGridView1.ClearSelection();
                    }
                }
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void AddCliente_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void MostrarClientes()
        {
            List<Persona> lista = PersonaContainer.personas;
            bs.DataSource = typeof(Persona);
            bs.DataSource = lista;
            dataGridView1.DataSource = bs;
            dataGridView1.AutoGenerateColumns = true;
        }
    }
}
