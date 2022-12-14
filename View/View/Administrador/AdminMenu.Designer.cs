namespace ViewAeropuerto.View.Administrador
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
            this.btnBilletes = new System.Windows.Forms.Button();
            this.btnVerBilletes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxFichero = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAeropuerto
            // 
            this.btnAeropuerto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAeropuerto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAeropuerto.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAeropuerto.Location = new System.Drawing.Point(30, 26);
            this.btnAeropuerto.Name = "btnAeropuerto";
            this.btnAeropuerto.Size = new System.Drawing.Size(206, 36);
            this.btnAeropuerto.TabIndex = 6;
            this.btnAeropuerto.Text = "Añadir aeropuertos";
            this.btnAeropuerto.Click += new System.EventHandler(this.btnAeropuerto_Click_1);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(30, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Añadir clientes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBilletes
            // 
            this.btnBilletes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBilletes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBilletes.ForeColor = System.Drawing.SystemColors.Info;
            this.btnBilletes.Location = new System.Drawing.Point(30, 109);
            this.btnBilletes.Name = "btnBilletes";
            this.btnBilletes.Size = new System.Drawing.Size(206, 33);
            this.btnBilletes.TabIndex = 3;
            this.btnBilletes.Text = "Modificar billetes";
            this.btnBilletes.UseVisualStyleBackColor = true;
            this.btnBilletes.Click += new System.EventHandler(this.btnBilletes_Click);
            // 
            // btnVerBilletes
            // 
            this.btnVerBilletes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerBilletes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerBilletes.ForeColor = System.Drawing.SystemColors.Info;
            this.btnVerBilletes.Location = new System.Drawing.Point(30, 148);
            this.btnVerBilletes.Name = "btnVerBilletes";
            this.btnVerBilletes.Size = new System.Drawing.Size(206, 32);
            this.btnVerBilletes.TabIndex = 2;
            this.btnVerBilletes.Text = "Ver estadísticas";
            this.btnVerBilletes.UseVisualStyleBackColor = true;
            this.btnVerBilletes.Click += new System.EventHandler(this.btnVerBilletes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSalir.Location = new System.Drawing.Point(32, 302);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(206, 35);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir de la aplicación";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxFichero);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Location = new System.Drawing.Point(30, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 97);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // textBoxFichero
            // 
            this.textBoxFichero.Location = new System.Drawing.Point(6, 60);
            this.textBoxFichero.Name = "textBoxFichero";
            this.textBoxFichero.ReadOnly = true;
            this.textBoxFichero.Size = new System.Drawing.Size(196, 23);
            this.textBoxFichero.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.Location = new System.Drawing.Point(105, 22);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(97, 32);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar fichero";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCargar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCargar.Location = new System.Drawing.Point(6, 22);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(93, 32);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Cargar fichero";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "*.txt | *.doc";
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(271, 369);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBilletes);
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
        private Button btnBilletes;
        private Button btnVerBilletes;
        private Button btnSalir;
        private GroupBox groupBox1;
        private TextBox textBoxFichero;
        private Button btnGuardar;
        private Button btnCargar;
        private OpenFileDialog openFileDialog1;
    }
}