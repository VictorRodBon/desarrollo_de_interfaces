namespace ProyectoBanco
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dni = new System.Windows.Forms.TextBox();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.labelDni = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.botonSiguiente = new System.Windows.Forms.Button();
            this.botonCalcularMasDinero = new System.Windows.Forms.Button();
            this.botonCalcularMenosDinero = new System.Windows.Forms.Button();
            this.botonCalcularMayorIngreso = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.masDineroLabel = new System.Windows.Forms.Label();
            this.maxIngresoLabel = new System.Windows.Forms.Label();
            this.menosDineroLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dni);
            this.groupBox1.Controls.Add(this.cantidad);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.labelDni);
            this.groupBox1.Controls.Add(this.labelCantidad);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Location = new System.Drawing.Point(25, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(83, 45);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(100, 20);
            this.dni.TabIndex = 5;
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(83, 71);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(100, 20);
            this.cantidad.TabIndex = 4;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(83, 19);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 3;
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Location = new System.Drawing.Point(15, 48);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(29, 13);
            this.labelDni.TabIndex = 2;
            this.labelDni.Text = "DNI:";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(15, 74);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(52, 13);
            this.labelCantidad.TabIndex = 1;
            this.labelCantidad.Text = "Cantidad:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(14, 22);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre:";
            // 
            // botonSiguiente
            // 
            this.botonSiguiente.Location = new System.Drawing.Point(284, 35);
            this.botonSiguiente.Name = "botonSiguiente";
            this.botonSiguiente.Size = new System.Drawing.Size(75, 23);
            this.botonSiguiente.TabIndex = 1;
            this.botonSiguiente.Text = "Siguiente";
            this.botonSiguiente.UseVisualStyleBackColor = true;
            this.botonSiguiente.Click += new System.EventHandler(this.botonSiguiente_Click);
            // 
            // botonCalcularMasDinero
            // 
            this.botonCalcularMasDinero.Location = new System.Drawing.Point(284, 166);
            this.botonCalcularMasDinero.Name = "botonCalcularMasDinero";
            this.botonCalcularMasDinero.Size = new System.Drawing.Size(75, 23);
            this.botonCalcularMasDinero.TabIndex = 2;
            this.botonCalcularMasDinero.Text = "->";
            this.botonCalcularMasDinero.UseVisualStyleBackColor = true;
            this.botonCalcularMasDinero.Click += new System.EventHandler(this.botonCalcularMasDinero_Click);
            // 
            // botonCalcularMenosDinero
            // 
            this.botonCalcularMenosDinero.Location = new System.Drawing.Point(284, 195);
            this.botonCalcularMenosDinero.Name = "botonCalcularMenosDinero";
            this.botonCalcularMenosDinero.Size = new System.Drawing.Size(75, 23);
            this.botonCalcularMenosDinero.TabIndex = 3;
            this.botonCalcularMenosDinero.Text = "->";
            this.botonCalcularMenosDinero.UseVisualStyleBackColor = true;
            this.botonCalcularMenosDinero.Click += new System.EventHandler(this.botonCalcularMenosDinero_Click);
            // 
            // botonCalcularMayorIngreso
            // 
            this.botonCalcularMayorIngreso.Location = new System.Drawing.Point(284, 224);
            this.botonCalcularMayorIngreso.Name = "botonCalcularMayorIngreso";
            this.botonCalcularMayorIngreso.Size = new System.Drawing.Size(75, 23);
            this.botonCalcularMayorIngreso.TabIndex = 4;
            this.botonCalcularMayorIngreso.Text = "->";
            this.botonCalcularMayorIngreso.UseVisualStyleBackColor = true;
            this.botonCalcularMayorIngreso.Click += new System.EventHandler(this.botonCalcularMayorIngreso_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cli. mas dinero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mayor ingreso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cli. menos dinero";
            // 
            // masDineroLabel
            // 
            this.masDineroLabel.AutoSize = true;
            this.masDineroLabel.Location = new System.Drawing.Point(166, 171);
            this.masDineroLabel.Name = "masDineroLabel";
            this.masDineroLabel.Size = new System.Drawing.Size(13, 13);
            this.masDineroLabel.TabIndex = 9;
            this.masDineroLabel.Text = "0";
            // 
            // maxIngresoLabel
            // 
            this.maxIngresoLabel.AutoSize = true;
            this.maxIngresoLabel.Location = new System.Drawing.Point(166, 229);
            this.maxIngresoLabel.Name = "maxIngresoLabel";
            this.maxIngresoLabel.Size = new System.Drawing.Size(13, 13);
            this.maxIngresoLabel.TabIndex = 10;
            this.maxIngresoLabel.Text = "0";
            // 
            // menosDineroLabel
            // 
            this.menosDineroLabel.AutoSize = true;
            this.menosDineroLabel.Location = new System.Drawing.Point(166, 200);
            this.menosDineroLabel.Name = "menosDineroLabel";
            this.menosDineroLabel.Size = new System.Drawing.Size(13, 13);
            this.menosDineroLabel.TabIndex = 11;
            this.menosDineroLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 319);
            this.Controls.Add(this.menosDineroLabel);
            this.Controls.Add(this.maxIngresoLabel);
            this.Controls.Add(this.masDineroLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botonCalcularMayorIngreso);
            this.Controls.Add(this.botonCalcularMenosDinero);
            this.Controls.Add(this.botonCalcularMasDinero);
            this.Controls.Add(this.botonSiguiente);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button botonSiguiente;
        private System.Windows.Forms.Button botonCalcularMasDinero;
        private System.Windows.Forms.Button botonCalcularMenosDinero;
        private System.Windows.Forms.Button botonCalcularMayorIngreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label masDineroLabel;
        private System.Windows.Forms.Label maxIngresoLabel;
        private System.Windows.Forms.Label menosDineroLabel;
    }
}

