namespace GestionAlumnos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.matricularAlumnoButton = new System.Windows.Forms.Button();
            this.consultarAlumnosButton = new System.Windows.Forms.Button();
            this.salirButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.salirButton);
            this.panel1.Controls.Add(this.consultarAlumnosButton);
            this.panel1.Controls.Add(this.matricularAlumnoButton);
            this.panel1.Location = new System.Drawing.Point(10, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 84);
            this.panel1.TabIndex = 0;
            // 
            // matricularAlumnoButton
            // 
            this.matricularAlumnoButton.Location = new System.Drawing.Point(3, 0);
            this.matricularAlumnoButton.Name = "matricularAlumnoButton";
            this.matricularAlumnoButton.Size = new System.Drawing.Size(124, 23);
            this.matricularAlumnoButton.TabIndex = 0;
            this.matricularAlumnoButton.Text = "Matricular alumno";
            this.matricularAlumnoButton.UseVisualStyleBackColor = true;
            this.matricularAlumnoButton.Click += new System.EventHandler(this.matricularAlumnoButton_Click);
            // 
            // consultarAlumnosButton
            // 
            this.consultarAlumnosButton.Location = new System.Drawing.Point(3, 29);
            this.consultarAlumnosButton.Name = "consultarAlumnosButton";
            this.consultarAlumnosButton.Size = new System.Drawing.Size(124, 23);
            this.consultarAlumnosButton.TabIndex = 1;
            this.consultarAlumnosButton.Text = "Consultar alumnos";
            this.consultarAlumnosButton.UseVisualStyleBackColor = true;
            this.consultarAlumnosButton.Click += new System.EventHandler(this.consultarAlumnosButton_Click);
            // 
            // salirButton
            // 
            this.salirButton.Location = new System.Drawing.Point(3, 58);
            this.salirButton.Name = "salirButton";
            this.salirButton.Size = new System.Drawing.Size(124, 23);
            this.salirButton.TabIndex = 2;
            this.salirButton.Text = "Salir";
            this.salirButton.UseVisualStyleBackColor = true;
            this.salirButton.Click += new System.EventHandler(this.salirButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 101);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button salirButton;
        private System.Windows.Forms.Button consultarAlumnosButton;
        private System.Windows.Forms.Button matricularAlumnoButton;
    }
}

