using ViewAeropuerto.Model;
using ViewAeropuerto.View.Cliente;

namespace ViewAeropuerto
{
    public partial class FormularioVuelo : Form
    {
        private string datoOrigen = string.Empty;
        private string datoDestino = string.Empty;
        private DateTime? fechaIda = null;
        private DateTime? fechaVuelta = null;
        private ComprarBillete formdatos;
        public ClientMenu menu;
        private bool isSoloIda = false;

        public FormularioVuelo(ClientMenu menu)
        {
            InitializeComponent();
            var fecha = DateTime.Now.Date;
            fechaIda = fecha;
            label3.Text = fecha.ToString();
            formdatos = new ComprarBillete(this);
            formdatos.Hide();
            labeldatos1.Hide();
            this.menu = menu;
            comboBoxOrigen.Items.Clear();
            comboBoxDestino.Items.Clear();
            this.comboBoxOrigen.Items.AddRange(AeropuertoContainer.DameLista().ToArray());
            this.comboBoxDestino.Items.AddRange(AeropuertoContainer.DameLista().ToArray());
        }

        private void btSelectVuelta_Click(object sender, EventArgs e)
        {
            if (monthCalendarVuelta.Enabled)
            {
                monthCalendarVuelta.Hide();
                monthCalendarVuelta.Enabled = false;
                btSelectVuelta.Text = "Seleccionar vuelta";
                fechaVuelta = null;
                label4.Text = string.Empty;
                labelFechaVuelta.Visible = false;
                isSoloIda = true;


            }
            else
            {
                monthCalendarVuelta.Show();
                monthCalendarVuelta.Enabled = true;
                btSelectVuelta.Text = "No seleccionar vuelta";
                labelFechaVuelta.Visible = true;
                isSoloIda = false;
            }
        }

        private void comboBoxOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDestino.SelectedIndex=-1;
            label2.Text = string.Empty;
            comboBoxDestino.Items.Clear();
            this.comboBoxDestino.Items.AddRange(AeropuertoContainer.DameLista().ToArray());
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
            fechaIda = DateTime.Parse(monthCalendarIda.SelectionEnd.ToString());
            label4.Text = string.Empty;
            fechaVuelta = null;
        }

        private void monthCalendarVuelta_DateChanged(object sender, DateRangeEventArgs e)
        {
            label4.Text = monthCalendarVuelta.SelectionEnd.ToString();
            fechaVuelta = DateTime.Parse(monthCalendarVuelta.SelectionEnd.ToString());
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
            if ((Checkear() && CheckearSoloIda()) || (!Checkear() && !CheckearSoloIda()))
            {
                if (Message1())
                {
                    formdatos.ClearDatos();
                    if (!isSoloIda)
                    {
                        MessageBox.Show(datoOrigen + " a " + datoDestino + Environment.NewLine + "del " + fechaIda + " al " + fechaVuelta, "Reservado");
                        var vueloIda = new Vuelo()
                        {
                            Origen = new Aeropuerto() { Lugar = datoOrigen },
                            Destino = new Aeropuerto() { Lugar = datoDestino },
                            Fecha = fechaIda ?? DateTime.Now
                        };
                        formdatos.vueloIda = vueloIda;
                        var vueloVuelta = new Vuelo()
                        {
                            Origen = new Aeropuerto() { Lugar = datoDestino },
                            Destino = new Aeropuerto() { Lugar = datoOrigen },
                            Fecha = fechaVuelta ?? DateTime.Now
                        };
                        formdatos.vueloVuelta = vueloVuelta;
                    }
                    else
                    {
                        MessageBox.Show("Viaje desde " + datoOrigen + " el día " + fechaIda, "Reservado");
                        var vueloIda = new Vuelo()
                        {
                            Origen = new Aeropuerto() { Lugar = datoOrigen },
                            Destino = new Aeropuerto() { Lugar = datoDestino },
                            Fecha = fechaIda ?? DateTime.Now
                        };
                        formdatos.vueloIda = vueloIda;
                        formdatos.vueloVuelta = null;
                    }
                    formdatos.Actualizar();
                    formdatos.CheckearCampos();
                    formdatos.ShowDialog();
                    labeldatos1.Show();

                    labeldatos2.Text = formdatos.GenerarBillete().MostrarBillete();
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
            if(fechaIda != null && datoOrigen != string.Empty && fechaVuelta != null && datoDestino != string.Empty)
            {
                return true;
            }
            return false;
        }
        private bool CheckearSoloIda()
        {
            if (fechaIda != null && datoOrigen != string.Empty && isSoloIda && datoDestino != string.Empty)
            {
                return false;
            }
            return true;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }
    }
}