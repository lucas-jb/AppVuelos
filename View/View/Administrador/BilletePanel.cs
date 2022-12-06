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

namespace ViewAeropuerto.View.Administrador
{
    public partial class BilletePanel : Form
    {

        private int celselected = -1;
        private AdminMenu menu;
        BindingSource bs = new BindingSource();
        public BilletePanel(AdminMenu menu)
        {
            this.menu = menu;
            InitializeComponent();
            //CheckearCampos();
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

        public void ClearDatos()
        {
            this.comboBoxOrigen.SelectedIndex = -1;
            this.dateTimePickerDestino.Value = DateTime.Now;
            this.comboBoxDestino.SelectedIndex = -1;
            this.dateTimePickerDestino.Value = DateTime.Now;
        }
        //public bool RellenadoCheck()
        //{
        //    if (this.textBoxName.Text != string.Empty && this.textBoxLugar.Text != string.Empty && this.textBoxDescription.Text != string.Empty)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        private void MostrarBilletes()
        {
            List<Billete> lista = BilleteContainer.billetes;
            foreach (Billete billete in lista)
            {
                dataGridView1.Rows.Add(billete.Id.ToString(), billete.Pasajero.Dni, billete.Ida.Origen.Lugar, billete.Vuelta.Origen.Lugar);
            }
            //bs.DataSource = typeof(Billete);
            //bs.DataSource = lista;
            //dataGridView1.DataSource = bs;
            //dataGridView1.AutoGenerateColumns = true;
        }

        //private void btnAdd_Click_1(object sender, EventArgs e)
        //{
        //    if (!RellenadoCheck())
        //    {
        //        MessageBox.Show("Faltan datos", "Cancelado");
        //    }
        //    else
        //    {
        //        Billete billete = new Billete()
        //        {
        //            Nombre = textBoxName.Text,
        //            Lugar = textBoxLugar.Text,
        //            Descripcion = textBoxDescription.Text,
        //        };
        //        BilleteContainer.billetes.(billete);
        //        MostrarClientes();
        //        ClearDatos();
        //    }
        //}


        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            celselected = e.RowIndex;
        }

        private void AeropuertoPanel_Load(object sender, EventArgs e)
        {
            MostrarBilletes();
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
        }

        private void BilletePanel_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("BilleteId", "Billete Id");
            dataGridView1.Columns.Add("PasajeroId", "Pasajero Id");
            dataGridView1.Columns.Add("Origen", "Origen");
            dataGridView1.Columns.Add("Destino", "Destino");
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
    }
}
