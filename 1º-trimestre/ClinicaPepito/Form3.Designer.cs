namespace ClinicaPepito
{
    partial class ConsultarCitas
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
            this.labelNumeroPaciente = new System.Windows.Forms.Label();
            this.numeroCliente = new System.Windows.Forms.TextBox();
            this.labelCita = new System.Windows.Forms.Label();
            this.labelFechaCita = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumeroPaciente
            // 
            this.labelNumeroPaciente.AutoSize = true;
            this.labelNumeroPaciente.Location = new System.Drawing.Point(13, 23);
            this.labelNumeroPaciente.Name = "labelNumeroPaciente";
            this.labelNumeroPaciente.Size = new System.Drawing.Size(109, 13);
            this.labelNumeroPaciente.TabIndex = 0;
            this.labelNumeroPaciente.Text = "Numero de paciente: ";
            // 
            // numeroCliente
            // 
            this.numeroCliente.Location = new System.Drawing.Point(129, 15);
            this.numeroCliente.Name = "numeroCliente";
            this.numeroCliente.Size = new System.Drawing.Size(100, 20);
            this.numeroCliente.TabIndex = 1;
            // 
            // labelCita
            // 
            this.labelCita.AutoSize = true;
            this.labelCita.Location = new System.Drawing.Point(12, 48);
            this.labelCita.Name = "labelCita";
            this.labelCita.Size = new System.Drawing.Size(28, 13);
            this.labelCita.TabIndex = 3;
            this.labelCita.Text = "Cita:";
            // 
            // labelFechaCita
            // 
            this.labelFechaCita.AutoSize = true;
            this.labelFechaCita.Location = new System.Drawing.Point(13, 70);
            this.labelFechaCita.Name = "labelFechaCita";
            this.labelFechaCita.Size = new System.Drawing.Size(26, 13);
            this.labelFechaCita.TabIndex = 2;
            this.labelFechaCita.Text = "Dia;";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(154, 38);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ConsultarCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 143);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.labelCita);
            this.Controls.Add(this.labelFechaCita);
            this.Controls.Add(this.numeroCliente);
            this.Controls.Add(this.labelNumeroPaciente);
            this.Name = "ConsultarCitas";
            this.Text = "Clinica Pepito | Consultar Citas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumeroPaciente;
        private System.Windows.Forms.TextBox numeroCliente;
        private System.Windows.Forms.Label labelCita;
        private System.Windows.Forms.Label labelFechaCita;
        private System.Windows.Forms.Button btnBuscar;
    }
}