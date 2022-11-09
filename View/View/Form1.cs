using View.Model;

namespace View
{
    public partial class Form1 : Form
    {
        private string datoOrigen = string.Empty;
        private string datoDestino = string.Empty;
        private string fechaIda = string.Empty;
        private string fechaVuelta = string.Empty;
        private Form2 formdatos;


        public Form1()
        {
            InitializeComponent();
            var fecha = DateTime.Now.Date;
            label3.Text = fecha.ToString();
            formdatos = new Form2();
            formdatos.Hide();
            labeldatos1.Hide();
        }

        private void btSelectVuelta_Click(object sender, EventArgs e)
        {
            if (monthCalendarVuelta.Enabled)
            {
                monthCalendarVuelta.Hide();
                monthCalendarVuelta.Enabled = false;
                btSelectVuelta.Text = "Seleccionar vuelta";
                fechaVuelta = string.Empty;
                label4.Text = string.Empty;
            }
            else
            {
                monthCalendarVuelta.Show();
                monthCalendarVuelta.Enabled = true;
                btSelectVuelta.Text = "No seleccionar vuelta";
            }
        }

        private void comboBoxOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDestino.SelectedIndex=-1;
            label2.Text = string.Empty;
            comboBoxDestino.Items.Clear();
            this.comboBoxDestino.Items.AddRange(new object[] {
            "Dubai",
            "Cancún",
            "Estambul",
            "Nueva York",
            "Miami",
            "París",
            "Londres"});
            int index = comboBoxOrigen.SelectedIndex;
            comboBoxDestino.Enabled = true;
            comboBoxDestino.Items.RemoveAt(index);
            label1.Text = comboBoxOrigen.SelectedItem.ToString();
            datoOrigen = comboBoxOrigen.SelectedItem.ToString() ?? string.Empty;
        }

        private void monthCalendarIda_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendarVuelta.MinDate = monthCalendarIda.SelectionRange.Start;
            label3.Text = monthCalendarIda.SelectionEnd.ToString();
            fechaIda = monthCalendarIda.SelectionEnd.ToString() ?? string.Empty;
            label4.Text = string.Empty;
            fechaVuelta = string.Empty;
        }

        private void monthCalendarVuelta_DateChanged(object sender, DateRangeEventArgs e)
        {
            label4.Text = monthCalendarVuelta.SelectionEnd.ToString();
            fechaVuelta = monthCalendarIda.SelectionEnd.ToString() ?? string.Empty;
        }

        private void comboBoxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if(comboBoxDestino.SelectedIndex != -1)
            {
                label2.Text = comboBoxDestino.SelectedItem.ToString();
                datoDestino = comboBoxDestino.SelectedItem.ToString() ?? string.Empty;
            }
            else
            {
                datoDestino = string.Empty;
            }
        }

        private bool Message1()
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            MessageBoxIcon icono = MessageBoxIcon.Question;
            String cuerpo = "¿Quiere confirmar la reserva?";
            String cabecera = "Confirmación";
            DialogResult resultado = MessageBox.Show(cuerpo, cabecera, botones, icono);
            if (resultado == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        private void btComprar_Click(object sender, EventArgs e)
        {
            if (Checkear())
            {
                if (Message1())
                {
                    formdatos.ClearDatos();
                    //MessageBox.Show(datoOrigen + " a "+ datoDestino + Environment.NewLine+ "del " + fechaIda + " al " + fechaVuelta, "Reservado");
                    formdatos.origen = datoOrigen;
                    formdatos.destino = datoDestino;
                    formdatos.fechaIda = fechaIda;
                    formdatos.fechaVuelta = fechaVuelta;
                    formdatos.Actualizar();
                    formdatos.CheckearCampos();
                    formdatos.ShowDialog();
                    labeldatos1.Show();

                    labeldatos2.Text = formdatos.Damepersona().MostrarPersona();

                }
                else
                {
                    MessageBox.Show("Vuelo cancelado con éxito", "Cancelado");
                }
            }
            else
            {
                MessageBox.Show("Falta información del vuelo", "Error");
            }
            
        }
        private Billete DameBillete()
        {
            return new Billete
            {

            } ?? new Billete();
        }
        private bool Checkear()
        {
            if(fechaIda != string.Empty && datoOrigen != string.Empty && datoDestino != string.Empty)
            {
                if(monthCalendarVuelta.Enabled && fechaVuelta == string.Empty)
                {
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}