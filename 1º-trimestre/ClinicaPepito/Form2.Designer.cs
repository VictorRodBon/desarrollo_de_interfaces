namespace ClinicaPepito
{
    partial class NuevaCita
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
            this.labelFecha = new System.Windows.Forms.Label();
            this.numeroPaciente = new System.Windows.Forms.TextBox();
            this.fechaCita = new System.Windows.Forms.DateTimePicker();
            this.btnGuardarCita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumeroPaciente
            // 
            this.labelNumeroPaciente.AutoSize = true;
            this.labelNumeroPaciente.Location = new System.Drawing.Point(42, 33);
            this.labelNumeroPaciente.Name = "labelNumeroPaciente";
            this.labelNumeroPaciente.Size = new System.Drawing.Size(109, 13);
            this.labelNumeroPaciente.TabIndex = 0;
            this.labelNumeroPaciente.Text = "Número de paciente: ";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(42, 63);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(43, 13);
            this.labelFecha.TabIndex = 1;
            this.labelFecha.Text = "Fecha: ";
            // 
            // numeroPaciente
            // 
            this.numeroPaciente.Location = new System.Drawing.Point(158, 33);
            this.numeroPaciente.Name = "numeroPaciente";
            this.numeroPaciente.Size = new System.Drawing.Size(100, 20);
            this.numeroPaciente.TabIndex = 2;
            // 
            // fechaCita
            // 
            this.fechaCita.Location = new System.Drawing.Point(158, 59);
            this.fechaCita.Name = "fechaCita";
            this.fechaCita.Size = new System.Drawing.Size(200, 20);
            this.fechaCita.TabIndex = 3;
            // 
            // btnGuardarCita
            // 
            this.btnGuardarCita.Location = new System.Drawing.Point(158, 86);
            this.btnGuardarCita.Name = "btnGuardarCita";
            this.btnGuardarCita.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarCita.TabIndex = 4;
            this.btnGuardarCita.Text = "Guardar cita";
            this.btnGuardarCita.UseVisualStyleBackColor = true;
            this.btnGuardarCita.Click += new System.EventHandler(this.btnGuardarCita_Click);
            // 
            // NuevaCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 130);
            this.Controls.Add(this.btnGuardarCita);
            this.Controls.Add(this.fechaCita);
            this.Controls.Add(this.numeroPaciente);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelNumeroPaciente);
            this.Name = "NuevaCita";
            this.Text = "Clinica Pepito | Nueva Cita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumeroPaciente;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.TextBox numeroPaciente;
        private System.Windows.Forms.DateTimePicker fechaCita;
        private System.Windows.Forms.Button btnGuardarCita;
    }
}