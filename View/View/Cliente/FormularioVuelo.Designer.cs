using ViewAeropuerto.Model;

namespace ViewAeropuerto
{
    partial class FormularioVuelo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendarIda = new System.Windows.Forms.MonthCalendar();
            this.monthCalendarVuelta = new System.Windows.Forms.MonthCalendar();
            this.btComprar = new System.Windows.Forms.Button();
            this.comboBoxOrigen = new System.Windows.Forms.ComboBox();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.btSelectVuelta = new System.Windows.Forms.Button();
            this.labelOrigen = new System.Windows.Forms.Label();
            this.labelDestino = new System.Windows.Forms.Label();
            this.labelVueloOrigen = new System.Windows.Forms.Label();
            this.labelVueloDestino = new System.Windows.Forms.Label();
            this.labelFechaIda = new System.Windows.Forms.Label();
            this.labelFechaVuelta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labeldatos1 = new System.Windows.Forms.Label();
            this.labeldatos2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendarIda
            // 
            this.monthCalendarIda.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monthCalendarIda.Location = new System.Drawing.Point(50, 77);
            this.monthCalendarIda.MinDate = new System.DateTime(2022, 11, 7, 0, 0, 0, 0);
            this.monthCalendarIda.Name = "monthCalendarIda";
            this.monthCalendarIda.TabIndex = 0;
            this.monthCalendarIda.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarIda_DateChanged);
            // 
            // monthCalendarVuelta
            // 
            this.monthCalendarVuelta.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.monthCalendarVuelta.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monthCalendarVuelta.ForeColor = System.Drawing.SystemColors.Info;
            this.monthCalendarVuelta.Location = new System.Drawing.Point(321, 80);
            this.monthCalendarVuelta.MinDate = new System.DateTime(2022, 11, 7, 0, 0, 0, 0);
            this.monthCalendarVuelta.Name = "monthCalendarVuelta";
            this.monthCalendarVuelta.TabIndex = 1;
            this.monthCalendarVuelta.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarVuelta_DateChanged);
            // 
            // btComprar
            // 
            this.btComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btComprar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btComprar.ForeColor = System.Drawing.SystemColors.Info;
            this.btComprar.Location = new System.Drawing.Point(45, 301);
            this.btComprar.Name = "btComprar";
            this.btComprar.Size = new System.Drawing.Size(468, 63);
            this.btComprar.TabIndex = 2;
            this.btComprar.Text = "Comprar billete";
            this.btComprar.UseVisualStyleBackColor = true;
            this.btComprar.Click += new System.EventHandler(this.btComprar_Click);
            // 
            // comboBoxOrigen
            // 
            this.comboBoxOrigen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBoxOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxOrigen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxOrigen.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBoxOrigen.FormattingEnabled = true;
            this.comboBoxOrigen.Items.AddRange(new object[] {
            "Dubái (EAU)",
            "Cancún (México)",
            "Estambul (Turquía)",
            "Nueva York (USA)",
            "Miami (USA)",
            "París (Francia)",
            "Doha (Qatar)",
            "Londres (Reino Unido)"});
            this.comboBoxOrigen.Location = new System.Drawing.Point(45, 27);
            this.comboBoxOrigen.Name = "comboBoxOrigen";
            this.comboBoxOrigen.Size = new System.Drawing.Size(197, 27);
            this.comboBoxOrigen.TabIndex = 3;
            this.comboBoxOrigen.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrigen_SelectedIndexChanged);
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBoxDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDestino.Enabled = false;
            this.comboBoxDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDestino.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxDestino.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Items.AddRange(new object[] {
            "Dubái (EAU)",
            "Cancún (México)",
            "Estambul (Turquía)",
            "Nueva York (USA)",
            "Miami (USA)",
            "París (Francia)",
            "Doha (Qatar)",
            "Londres (Reino Unido)"});
            this.comboBoxDestino.Location = new System.Drawing.Point(317, 28);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(196, 27);
            this.comboBoxDestino.TabIndex = 4;
            this.comboBoxDestino.SelectedIndexChanged += new System.EventHandler(this.comboBoxDestino_SelectedIndexChanged);
            // 
            // btSelectVuelta
            // 
            this.btSelectVuelta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSelectVuelta.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSelectVuelta.ForeColor = System.Drawing.SystemColors.Info;
            this.btSelectVuelta.Location = new System.Drawing.Point(532, 27);
            this.btSelectVuelta.Name = "btSelectVuelta";
            this.btSelectVuelta.Size = new System.Drawing.Size(180, 28);
            this.btSelectVuelta.TabIndex = 5;
            this.btSelectVuelta.Text = "No seleccionar vuelta";
            this.btSelectVuelta.UseVisualStyleBackColor = true;
            this.btSelectVuelta.Click += new System.EventHandler(this.btSelectVuelta_Click);
            // 
            // labelOrigen
            // 
            this.labelOrigen.AutoSize = true;
            this.labelOrigen.ForeColor = System.Drawing.SystemColors.Info;
            this.labelOrigen.Location = new System.Drawing.Point(45, 8);
            this.labelOrigen.Name = "labelOrigen";
            this.labelOrigen.Size = new System.Drawing.Size(43, 15);
            this.labelOrigen.TabIndex = 6;
            this.labelOrigen.Text = "Origen";
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.ForeColor = System.Drawing.SystemColors.Info;
            this.labelDestino.Location = new System.Drawing.Point(317, 11);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(47, 15);
            this.labelDestino.TabIndex = 7;
            this.labelDestino.Text = "Destino";
            // 
            // labelVueloOrigen
            // 
            this.labelVueloOrigen.AutoSize = true;
            this.labelVueloOrigen.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVueloOrigen.ForeColor = System.Drawing.SystemColors.Info;
            this.labelVueloOrigen.Location = new System.Drawing.Point(45, 248);
            this.labelVueloOrigen.Name = "labelVueloOrigen";
            this.labelVueloOrigen.Size = new System.Drawing.Size(171, 14);
            this.labelVueloOrigen.TabIndex = 8;
            this.labelVueloOrigen.Text = "Vuelo de origen seleccionado:";
            // 
            // labelVueloDestino
            // 
            this.labelVueloDestino.AutoSize = true;
            this.labelVueloDestino.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVueloDestino.ForeColor = System.Drawing.SystemColors.Info;
            this.labelVueloDestino.Location = new System.Drawing.Point(45, 263);
            this.labelVueloDestino.Name = "labelVueloDestino";
            this.labelVueloDestino.Size = new System.Drawing.Size(177, 14);
            this.labelVueloDestino.TabIndex = 9;
            this.labelVueloDestino.Text = "Vuelo de destino seleccionado:";
            // 
            // labelFechaIda
            // 
            this.labelFechaIda.AutoSize = true;
            this.labelFechaIda.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFechaIda.ForeColor = System.Drawing.SystemColors.Info;
            this.labelFechaIda.Location = new System.Drawing.Point(351, 252);
            this.labelFechaIda.Name = "labelFechaIda";
            this.labelFechaIda.Size = new System.Drawing.Size(103, 14);
            this.labelFechaIda.TabIndex = 10;
            this.labelFechaIda.Text = "Con fecha de ida:";
            // 
            // labelFechaVuelta
            // 
            this.labelFechaVuelta.AutoSize = true;
            this.labelFechaVuelta.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFechaVuelta.ForeColor = System.Drawing.SystemColors.Info;
            this.labelFechaVuelta.Location = new System.Drawing.Point(351, 266);
            this.labelFechaVuelta.Name = "labelFechaVuelta";
            this.labelFechaVuelta.Size = new System.Drawing.Size(121, 14);
            this.labelFechaVuelta.TabIndex = 11;
            this.labelFechaVuelta.Text = "Con fecha de vuelta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 15;
            // 
            // labeldatos1
            // 
            this.labeldatos1.AutoSize = true;
            this.labeldatos1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeldatos1.ForeColor = System.Drawing.SystemColors.Info;
            this.labeldatos1.Location = new System.Drawing.Point(45, 382);
            this.labeldatos1.Name = "labeldatos1";
            this.labeldatos1.Size = new System.Drawing.Size(183, 14);
            this.labeldatos1.TabIndex = 16;
            this.labeldatos1.Text = "Compra realizada con éxito para:";
            // 
            // labeldatos2
            // 
            this.labeldatos2.AutoSize = true;
            this.labeldatos2.Location = new System.Drawing.Point(231, 382);
            this.labeldatos2.Name = "labeldatos2";
            this.labeldatos2.Size = new System.Drawing.Size(0, 15);
            this.labeldatos2.TabIndex = 17;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSalir.Location = new System.Drawing.Point(532, 301);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(180, 63);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormularioVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(724, 607);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.labeldatos2);
            this.Controls.Add(this.labeldatos1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFechaVuelta);
            this.Controls.Add(this.labelFechaIda);
            this.Controls.Add(this.labelVueloDestino);
            this.Controls.Add(this.labelVueloOrigen);
            this.Controls.Add(this.labelDestino);
            this.Controls.Add(this.labelOrigen);
            this.Controls.Add(this.btSelectVuelta);
            this.Controls.Add(this.comboBoxDestino);
            this.Controls.Add(this.comboBoxOrigen);
            this.Controls.Add(this.btComprar);
            this.Controls.Add(this.monthCalendarVuelta);
            this.Controls.Add(this.monthCalendarIda);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Name = "FormularioVuelo";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MonthCalendar monthCalendarIda;
        private MonthCalendar monthCalendarVuelta;
        private Button btComprar;
        private ComboBox comboBoxOrigen;
        private ComboBox comboBoxDestino;
        private Button btSelectVuelta;
        private Label labelOrigen;
        private Label labelDestino;
        private Label labelVueloOrigen;
        private Label labelVueloDestino;
        private Label labelFechaIda;
        private Label labelFechaVuelta;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labeldatos1;
        private Label labeldatos2;
        private Button btnSalir;
    }
}