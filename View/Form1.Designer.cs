namespace View
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // monthCalendarIda
            // 
            this.monthCalendarIda.Location = new System.Drawing.Point(54, 149);
            this.monthCalendarIda.MinDate = new System.DateTime(2022, 11, 7, 0, 0, 0, 0);
            this.monthCalendarIda.Name = "monthCalendarIda";
            this.monthCalendarIda.TabIndex = 0;
            this.monthCalendarIda.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarIda_DateChanged);
            // 
            // monthCalendarVuelta
            // 
            this.monthCalendarVuelta.Location = new System.Drawing.Point(468, 149);
            this.monthCalendarVuelta.MinDate = new System.DateTime(2022, 11, 7, 0, 0, 0, 0);
            this.monthCalendarVuelta.Name = "monthCalendarVuelta";
            this.monthCalendarVuelta.TabIndex = 1;
            this.monthCalendarVuelta.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarVuelta_DateChanged);
            // 
            // btComprar
            // 
            this.btComprar.Location = new System.Drawing.Point(250, 375);
            this.btComprar.Name = "btComprar";
            this.btComprar.Size = new System.Drawing.Size(220, 63);
            this.btComprar.TabIndex = 2;
            this.btComprar.Text = "Comprar billetes";
            this.btComprar.UseVisualStyleBackColor = true;
            this.btComprar.Click += new System.EventHandler(this.btComprar_Click);
            // 
            // comboBoxOrigen
            // 
            this.comboBoxOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrigen.FormattingEnabled = true;
            this.comboBoxOrigen.Items.AddRange(new object[] {
            "Dubai",
            "Cancún",
            "Estambul",
            "Nueva York",
            "Miami",
            "París",
            "Londres"});
            this.comboBoxOrigen.Location = new System.Drawing.Point(54, 30);
            this.comboBoxOrigen.Name = "comboBoxOrigen";
            this.comboBoxOrigen.Size = new System.Drawing.Size(121, 23);
            this.comboBoxOrigen.TabIndex = 3;
            this.comboBoxOrigen.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrigen_SelectedIndexChanged);
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDestino.Enabled = false;
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Items.AddRange(new object[] {
            "Dubai",
            "Cancún",
            "Estambul",
            "Nueva York",
            "Miami",
            "París",
            "Londres"});
            this.comboBoxDestino.Location = new System.Drawing.Point(199, 30);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(121, 23);
            this.comboBoxDestino.TabIndex = 4;
            this.comboBoxDestino.SelectedIndexChanged += new System.EventHandler(this.comboBoxDestino_SelectedIndexChanged);
            // 
            // btSelectVuelta
            // 
            this.btSelectVuelta.Location = new System.Drawing.Point(330, 29);
            this.btSelectVuelta.Name = "btSelectVuelta";
            this.btSelectVuelta.Size = new System.Drawing.Size(140, 23);
            this.btSelectVuelta.TabIndex = 5;
            this.btSelectVuelta.Text = "No seleccionar vuelta";
            this.btSelectVuelta.UseVisualStyleBackColor = true;
            this.btSelectVuelta.Click += new System.EventHandler(this.btSelectVuelta_Click);
            // 
            // labelOrigen
            // 
            this.labelOrigen.AutoSize = true;
            this.labelOrigen.Location = new System.Drawing.Point(54, 12);
            this.labelOrigen.Name = "labelOrigen";
            this.labelOrigen.Size = new System.Drawing.Size(43, 15);
            this.labelOrigen.TabIndex = 6;
            this.labelOrigen.Text = "Origen";
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.Location = new System.Drawing.Point(199, 13);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(47, 15);
            this.labelDestino.TabIndex = 7;
            this.labelDestino.Text = "Destino";
            // 
            // labelVueloOrigen
            // 
            this.labelVueloOrigen.AutoSize = true;
            this.labelVueloOrigen.Location = new System.Drawing.Point(54, 320);
            this.labelVueloOrigen.Name = "labelVueloOrigen";
            this.labelVueloOrigen.Size = new System.Drawing.Size(165, 15);
            this.labelVueloOrigen.TabIndex = 8;
            this.labelVueloOrigen.Text = "Vuelo de origen seleccionado:";
            // 
            // labelVueloDestino
            // 
            this.labelVueloDestino.AutoSize = true;
            this.labelVueloDestino.Location = new System.Drawing.Point(49, 335);
            this.labelVueloDestino.Name = "labelVueloDestino";
            this.labelVueloDestino.Size = new System.Drawing.Size(170, 15);
            this.labelVueloDestino.TabIndex = 9;
            this.labelVueloDestino.Text = "Vuelo de destino seleccionado:";
            // 
            // labelFechaIda
            // 
            this.labelFechaIda.AutoSize = true;
            this.labelFechaIda.Location = new System.Drawing.Point(484, 320);
            this.labelFechaIda.Name = "labelFechaIda";
            this.labelFechaIda.Size = new System.Drawing.Size(99, 15);
            this.labelFechaIda.TabIndex = 10;
            this.labelFechaIda.Text = "Con fecha de ida:";
            // 
            // labelFechaVuelta
            // 
            this.labelFechaVuelta.AutoSize = true;
            this.labelFechaVuelta.Location = new System.Drawing.Point(468, 338);
            this.labelFechaVuelta.Name = "labelFechaVuelta";
            this.labelFechaVuelta.Size = new System.Drawing.Size(115, 15);
            this.labelFechaVuelta.TabIndex = 11;
            this.labelFechaVuelta.Text = "Con fecha de vuelta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(589, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form1";
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
    }
}