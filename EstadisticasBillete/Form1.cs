using EstadisticasBillete.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace EstadisticasBillete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PersonaContainer.BuildPersonaContainer();
        }

        private void CrearChart()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(660, 426);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.Controls.Add(this.chart1);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();

            chart1.Series.Clear();

            foreach (Persona p in PersonaContainer.personas)
            {
                Series s = chart1.Series.Add(p.Dni);
                s.Points.Add(p.Nbilletes);
                s.Label = p.Nombre;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CrearChart();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
