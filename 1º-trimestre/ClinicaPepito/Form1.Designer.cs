namespace ClinicaPepito
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonNuevaCita = new System.Windows.Forms.Button();
            this.botonConsultarCita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonNuevaCita
            // 
            this.botonNuevaCita.Location = new System.Drawing.Point(11, 24);
            this.botonNuevaCita.Name = "botonNuevaCita";
            this.botonNuevaCita.Size = new System.Drawing.Size(98, 82);
            this.botonNuevaCita.TabIndex = 0;
            this.botonNuevaCita.Text = "Nueva cita";
            this.botonNuevaCita.UseVisualStyleBackColor = true;
            this.botonNuevaCita.Click += new System.EventHandler(this.botonNuevaCita_Click);
            // 
            // botonConsultarCita
            // 
            this.botonConsultarCita.Location = new System.Drawing.Point(134, 24);
            this.botonConsultarCita.Name = "botonConsultarCita";
            this.botonConsultarCita.Size = new System.Drawing.Size(98, 82);
            this.botonConsultarCita.TabIndex = 1;
            this.botonConsultarCita.Text = "Consultar citas";
            this.botonConsultarCita.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 132);
            this.Controls.Add(this.botonConsultarCita);
            this.Controls.Add(this.botonNuevaCita);
            this.Name = "Form1";
            this.Text = "Clinica Pepito";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonNuevaCita;
        private System.Windows.Forms.Button botonConsultarCita;
    }
}

