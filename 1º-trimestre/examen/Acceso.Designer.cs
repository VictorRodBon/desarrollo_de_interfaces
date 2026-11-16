namespace examen
{
    partial class Acceso
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
            this.labelUsr = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxUsr = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonAcceso = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.labelUsuariosRegistrados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUsr
            // 
            this.labelUsr.AutoSize = true;
            this.labelUsr.Location = new System.Drawing.Point(52, 42);
            this.labelUsr.Name = "labelUsr";
            this.labelUsr.Size = new System.Drawing.Size(26, 13);
            this.labelUsr.TabIndex = 0;
            this.labelUsr.Text = "Usr:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(52, 82);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(33, 13);
            this.labelPass.TabIndex = 1;
            this.labelPass.Text = "Pass:";
            // 
            // textBoxUsr
            // 
            this.textBoxUsr.Location = new System.Drawing.Point(110, 35);
            this.textBoxUsr.Name = "textBoxUsr";
            this.textBoxUsr.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsr.TabIndex = 2;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(110, 75);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxPass.TabIndex = 3;
            // 
            // buttonAcceso
            // 
            this.buttonAcceso.Location = new System.Drawing.Point(55, 134);
            this.buttonAcceso.Name = "buttonAcceso";
            this.buttonAcceso.Size = new System.Drawing.Size(75, 23);
            this.buttonAcceso.TabIndex = 4;
            this.buttonAcceso.Text = "Acceso";
            this.buttonAcceso.UseVisualStyleBackColor = true;
            this.buttonAcceso.Click += new System.EventHandler(this.buttonAcceso_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(166, 134);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 5;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // labelUsuariosRegistrados
            // 
            this.labelUsuariosRegistrados.AutoSize = true;
            this.labelUsuariosRegistrados.Location = new System.Drawing.Point(172, 177);
            this.labelUsuariosRegistrados.Name = "labelUsuariosRegistrados";
            this.labelUsuariosRegistrados.Size = new System.Drawing.Size(110, 13);
            this.labelUsuariosRegistrados.TabIndex = 6;
            this.labelUsuariosRegistrados.Text = "Usuarios Registrados:";
            // 
            // Acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 199);
            this.Controls.Add(this.labelUsuariosRegistrados);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonAcceso);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUsr);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelUsr);
            this.Name = "Acceso";
            this.Text = "Acceso usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Acceso_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsr;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxUsr;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button buttonAcceso;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label labelUsuariosRegistrados;
    }
}

