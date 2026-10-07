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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelFechaCita = new System.Windows.Forms.Label();
            this.labelCita = new System.Windows.Forms.Label();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // labelFechaCita
            // 
            this.labelFechaCita.AutoSize = true;
            this.labelFechaCita.Location = new System.Drawing.Point(13, 70);
            this.labelFechaCita.Name = "labelFechaCita";
            this.labelFechaCita.Size = new System.Drawing.Size(23, 13);
            this.labelFechaCita.TabIndex = 2;
            this.labelFechaCita.Text = "Dia";
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
            // ConsultarCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 143);
            this.Controls.Add(this.labelCita);
            this.Controls.Add(this.labelFechaCita);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelNumeroPaciente);
            this.Name = "ConsultarCitas";
            this.Text = "Clinica Pepito | Consultar Citas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumeroPaciente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelFechaCita;
        private System.Windows.Forms.Label labelCita;
    }
}