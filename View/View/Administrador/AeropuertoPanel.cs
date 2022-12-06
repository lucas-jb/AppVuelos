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
    public partial class AeropuertoPanel : Form
    {
        private int celselected = -1;
        private AdminMenu menu;
        BindingSource bs = new BindingSource();
        public AeropuertoPanel(AdminMenu menu)
        {
            this.menu = menu;
            InitializeComponent();
            CheckearCampos();
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
            if (this.textBoxLugar.Text == string.Empty)
            {
                this.pictureBox2.Image = this.pictureBox1.ErrorImage;
            }
            else
            {
                this.pictureBox2.Image = this.pictureBox1.InitialImage;
            }
            if (this.textBoxDescription.Text == string.Empty)
            {
                this.pictureBox3.Image = this.pictureBox1.ErrorImage;
            }
            else
            {
                this.pictureBox3.Image = this.pictureBox1.InitialImage;
            }
            return true;
        }

        public void ClearDatos()
        {
            this.textBoxName.Text = string.Empty;
            this.textBoxLugar.Text = string.Empty;
            this.textBoxDescription.Text = string.Empty;
        }
        public bool RellenadoCheck()
        {
            if (this.textBoxName.Text != string.Empty && this.textBoxLugar.Text != string.Empty && this.textBoxDescription.Text != string.Empty)
            {
                return true;
            }
            return false;
        }

        private void MostrarClientes()
        {
            List<Aeropuerto> lista = AeropuertoContainer.aeropuertos;
            bs.DataSource = typeof(Aeropuerto);
            bs.DataSource = lista;
            dataGridView1.DataSource = bs;
            dataGridView1.AutoGenerateColumns = true;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (!RellenadoCheck())
            {
                MessageBox.Show("Faltan datos", "Cancelado");
            }
            else
            {
                Aeropuerto aeropuerto = new Aeropuerto()
                {
                    Nombre = textBoxName.Text,
                    Lugar = textBoxLugar.Text,
                    Descripcion = textBoxDescription.Text,
                };
                AeropuertoContainer.aeropuertos.Add(aeropuerto);
                MostrarClientes();
                ClearDatos();
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (celselected != -1 && dataGridView1.Rows.Count - 1 != celselected)
            {
                int index = dataGridView1.SelectedCells[0].RowIndex;
                string? id = dataGridView1.Rows[index].Cells[3].Value.ToString();
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                string cuerpo = "Este aeropuerto tiene vuelos asociados. ¿Eliminar aún así?";
                string cabecera = "ATENCIÓN";
                DialogResult resultado = MessageBox.Show(cuerpo, cabecera, botones);
                if (resultado == DialogResult.Yes)
                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[celselected]);
                    celselected = -1;
                    dataGridView1.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("No has seleccionado ningun aeropuerto", "Cancelado");
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            celselected = e.RowIndex;
        }

        private void AeropuertoPanel_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void textBoxName_TextChanged_1(object sender, EventArgs e)
        {
            CheckearCampos();
        }

        private void textBoxLugar_TextChanged(object sender, EventArgs e)
        {
            CheckearCampos();
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            CheckearCampos();
        }
    }
}