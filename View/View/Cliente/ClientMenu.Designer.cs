namespace View.View.Cliente
{
    partial class ClientMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientMenu));
            this.btn = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnVerVuelo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelDatos = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn.ForeColor = System.Drawing.SystemColors.Info;
            this.btn.Location = new System.Drawing.Point(24, 33);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(210, 23);
            this.btn.TabIndex = 0;
            this.btn.Text = "Comprar billete";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnHistorico.ForeColor = System.Drawing.SystemColors.Info;
            this.btnHistorico.Location = new System.Drawing.Point(24, 188);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(210, 23);
            this.btnHistorico.TabIndex = 1;
            this.btnHistorico.Text = "Ver historico";
            this.btnHistorico.UseVisualStyleBackColor = false;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSalir.Location = new System.Drawing.Point(24, 228);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(210, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir de la aplicación";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnVerVuelo);
            this.groupBox1.Location = new System.Drawing.Point(26, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 102);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mi vuelo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 23);
            this.textBox1.TabIndex = 5;
            // 
            // btnVerVuelo
            // 
            this.btnVerVuelo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnVerVuelo.ForeColor = System.Drawing.SystemColors.Info;
            this.btnVerVuelo.Location = new System.Drawing.Point(22, 33);
            this.btnVerVuelo.Name = "btnVerVuelo";
            this.btnVerVuelo.Size = new System.Drawing.Size(173, 23);
            this.btnVerVuelo.TabIndex = 4;
            this.btnVerVuelo.Text = "Ver mi vuelo";
            this.btnVerVuelo.UseVisualStyleBackColor = false;
            this.btnVerVuelo.Click += new System.EventHandler(this.btnVerVuelo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelDatos);
            this.groupBox2.Location = new System.Drawing.Point(261, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 232);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // labelDatos
            // 
            this.labelDatos.AutoSize = true;
            this.labelDatos.Location = new System.Drawing.Point(6, 28);
            this.labelDatos.Name = "labelDatos";
            this.labelDatos.Size = new System.Drawing.Size(0, 15);
            this.labelDatos.TabIndex = 0;
            // 
            // ClientMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(531, 263);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientMenu";
            this.Text = "Menú cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn;
        private Button btnHistorico;
        private Button btnSalir;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Button btnVerVuelo;
        private GroupBox groupBox2;
        private Label labelDatos;
    }
}