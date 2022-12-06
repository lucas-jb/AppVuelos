using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewAeropuerto.Model;

namespace ViewAeropuerto.View.Administrador
{
    public partial class BilletePanel : Form
    {

        private int celselected = -1;
        private AdminMenu menu;
        BindingSource bs = new BindingSource();
        private string dniSelected = string.Empty;
        private string ida = string.Empty;
        private string vuelta = string.Empty;
        public BilletePanel(AdminMenu menu)
        {
            this.menu = menu;
            InitializeComponent();
        }

        public bool CheckearCampos()
        {
            if (this.comboBoxOrigen.SelectedIndex == -1)
            {
                this.pictureBox1.Image = this.pictureBox1.ErrorImage;
            }
            else
            {
                this.pictureBox1.Image = this.pictureBox1.InitialImage;
            }
            if (this.dateTimePickerOrigen.Value < DateTime.Now)
            {
                this.pictureBox2.Image = this.pictureBox1.ErrorImage;
            }
            else
            {
                this.pictureBox2.Image = this.pictureBox1.InitialImage;
            }
            if (this.comboBoxDestino.SelectedIndex == -1)
            {
                this.pictureBox3.Image = this.pictureBox1.ErrorImage;
            }
            else
            {
                this.pictureBox3.Image = this.pictureBox1.InitialImage;
            }
            if (this.dateTimePickerDestino.Value < DateTime.Now)
            {
                this.pictureBox2.Image = this.pictureBox1.ErrorImage;
            }
            else
            {
                this.pictureBox2.Image = this.pictureBox1.InitialImage;
            }
            return true;
        }

        private void MostrarBilletes()
        {
            dataGridView1.Rows.Clear();
            List<Billete> lista = BilleteContainer.billetes;
            foreach (Billete billete in lista)
            {
                dataGridView1.Rows.Add(billete.Id.ToString(), billete.Pasajero.Dni, billete.Ida.Origen.Lugar, billete.Ida.Fecha, billete.Vuelta.Origen.Lugar, billete.Vuelta.Fecha);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void comboBoxOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDestino.SelectedIndex = -1;
            comboBoxDestino.Items.Clear();
            this.comboBoxDestino.Items.AddRange(Vuelo.lugares.ToArray());
            int index = comboBoxOrigen.SelectedIndex;
            comboBoxDestino.Enabled = true;
            comboBoxDestino.Items.RemoveAt(index);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            celselected = e.RowIndex;
            try
            {
                int index = dataGridView1.SelectedCells[0].RowIndex;
                comboBoxOrigen.Text = string.Empty;
                comboBoxDestino.Text = string.Empty;
                dniSelected = dataGridView1.Rows[index].Cells[1].Value.ToString();
                this.comboBoxOrigen.SelectedText = dataGridView1.Rows[index].Cells[2].Value.ToString();
                //this.ida = dataGridView1.Rows[index].Cells[2].Value.ToString();
                this.comboBoxDestino.SelectedText = dataGridView1.Rows[index].Cells[4].Value.ToString();
                //this.vuelta = dataGridView1.Rows[index].Cells[4].Value.ToString();
                this.dateTimePickerOrigen.Value = DateTime.Parse(dataGridView1.Rows[index].Cells[3].Value.ToString());
                this.dateTimePickerDestino.Value = DateTime.Parse(dataGridView1.Rows[index].Cells[5].Value.ToString());
                string? id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Hubo un error al seleccionar el billete", "Error");
            }

        }

        private void BilletePanel_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("BilleteId", "Billete Id");
            dataGridView1.Columns.Add("PasajeroId", "Pasajero Id");
            dataGridView1.Columns.Add("Origen", "Origen");
            dataGridView1.Columns.Add("FechaOrigen", "Fecha Origen");
            dataGridView1.Columns.Add("Destino", "Destino");
            dataGridView1.Columns.Add("FechaDestino", "Fecha Destino");
            MostrarBilletes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (celselected != -1 && dataGridView1.Rows.Count - 1 != celselected)
            {
                int index = dataGridView1.SelectedCells[0].RowIndex;
                string? id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                string cuerpo = "Este billete tiene un usuario asociado. ¿Eliminar aún así?";
                string cabecera = "ATENCIÓN";
                DialogResult resultado = MessageBox.Show(cuerpo, cabecera, botones);
                if (resultado == DialogResult.Yes)
                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[celselected]);
                    celselected = -1;
                    dataGridView1.ClearSelection();
                    BilleteContainer.DeleteBillete(Int32.Parse(id));
                }
            }
            else
            {
                MessageBox.Show("No has seleccionado ningun billete", "Cancelado");
            }
        }

        private void comboBoxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (celselected != -1 && dataGridView1.Rows.Count - 1 != celselected)
            {
                int index = dataGridView1.SelectedCells[0].RowIndex;
                string? id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                string cuerpo = "Este billete tiene un usuario asociado. ¿Editar aún así?";
                string cabecera = "ATENCIÓN";
                DialogResult resultado = MessageBox.Show(cuerpo, cabecera, botones);
                if (resultado == DialogResult.Yes)
                {
                    Billete billete = new Billete()
                    {
                        Id = Int32.Parse(id),
                        Ida = Vuelo.DameVueloPorAeropuerto(this.ida, this.vuelta, this.dateTimePickerOrigen.Value),
                        Vuelta = Vuelo.DameVueloPorAeropuerto(this.vuelta, this.ida, this.dateTimePickerDestino.Value),
                        Pasajero = PersonaContainer.BuscarDni(dniSelected)
                    };
                    dataGridView1.Rows.Remove(dataGridView1.Rows[celselected]);
                    celselected = -1;
                    dataGridView1.ClearSelection();
                    BilleteContainer.ModificarBillete(billete);
                    MostrarBilletes();
                }
            }
            else
            {
                MessageBox.Show("No has seleccionado ningun billete", "Cancelado");
            }
        }

        private void comboBoxOrigen_TextChanged(object sender, EventArgs e)
        {
            this.ida = comboBoxOrigen.Text;
        }

        private void comboBoxDestino_TextChanged(object sender, EventArgs e)
        {
            this.vuelta = comboBoxDestino.Text;
        }
    }
}
