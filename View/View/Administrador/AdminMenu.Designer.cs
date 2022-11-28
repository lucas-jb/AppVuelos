namespace View.View.Administrador
{
    partial class AdminMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.btnAeropuerto = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnVerBilletes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAeropuerto
            // 
            this.btnAeropuerto.Location = new System.Drawing.Point(31, 30);
            this.btnAeropuerto.Name = "btnAeropuerto";
            this.btnAeropuerto.Size = new System.Drawing.Size(206, 23);
            this.btnAeropuerto.TabIndex = 0;
            this.btnAeropuerto.Text = "Crear aeropuertos";
            this.btnAeropuerto.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Añadir clientes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Modificar billetes";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnVerBilletes
            // 
            this.btnVerBilletes.Location = new System.Drawing.Point(31, 113);
            this.btnVerBilletes.Name = "btnVerBilletes";
            this.btnVerBilletes.Size = new System.Drawing.Size(206, 23);
            this.btnVerBilletes.TabIndex = 2;
            this.btnVerBilletes.Text = "Ver billetes";
            this.btnVerBilletes.UseVisualStyleBackColor = true;
            this.btnVerBilletes.Click += new System.EventHandler(this.btnVerBilletes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(31, 311);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(206, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir de la aplicación";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.Location = new System.Drawing.Point(31, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 111);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 23);
            this.textBox1.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(105, 22);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(97, 44);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar fichero";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(6, 22);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(93, 44);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Cargar fichero";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(271, 348);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnVerBilletes);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAeropuerto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminMenu";
            this.Text = "Menú administrador";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAeropuerto;
        private Button button2;
        private Button button3;
        private Button btnVerBilletes;
        private Button btnSalir;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Button btnGuardar;
        private Button btnCargar;
    }
}