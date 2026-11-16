namespace examen
{
    partial class Registro
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
            this.labelUsr = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelNotas = new System.Windows.Forms.Label();
            this.labelNota1 = new System.Windows.Forms.Label();
            this.labelNota2 = new System.Windows.Forms.Label();
            this.labelNotaMedia = new System.Windows.Forms.Label();
            this.labelNotaMediaResultado = new System.Windows.Forms.Label();
            this.dateTimePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.textBoxUsr = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxNota1 = new System.Windows.Forms.TextBox();
            this.textBoxNota2 = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUsr
            // 
            this.labelUsr.AutoSize = true;
            this.labelUsr.Location = new System.Drawing.Point(12, 9);
            this.labelUsr.Name = "labelUsr";
            this.labelUsr.Size = new System.Drawing.Size(27, 13);
            this.labelUsr.TabIndex = 0;
            this.labelUsr.Text = "usr: ";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(12, 31);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(50, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre: ";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(142, 9);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(35, 13);
            this.labelPass.TabIndex = 2;
            this.labelPass.Text = "pass: ";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(12, 55);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(99, 13);
            this.labelFecha.TabIndex = 3;
            this.labelFecha.Text = "Fecha Nacimiento: ";
            // 
            // labelNotas
            // 
            this.labelNotas.AutoSize = true;
            this.labelNotas.Location = new System.Drawing.Point(12, 80);
            this.labelNotas.Name = "labelNotas";
            this.labelNotas.Size = new System.Drawing.Size(41, 13);
            this.labelNotas.TabIndex = 4;
            this.labelNotas.Text = "Notas: ";
            // 
            // labelNota1
            // 
            this.labelNota1.AutoSize = true;
            this.labelNota1.Location = new System.Drawing.Point(29, 103);
            this.labelNota1.Name = "labelNota1";
            this.labelNota1.Size = new System.Drawing.Size(57, 13);
            this.labelNota1.TabIndex = 5;
            this.labelNota1.Text = "Modulo 1: ";
            // 
            // labelNota2
            // 
            this.labelNota2.AutoSize = true;
            this.labelNota2.Location = new System.Drawing.Point(29, 126);
            this.labelNota2.Name = "labelNota2";
            this.labelNota2.Size = new System.Drawing.Size(57, 13);
            this.labelNota2.TabIndex = 6;
            this.labelNota2.Text = "Modulo 2: ";
            // 
            // labelNotaMedia
            // 
            this.labelNotaMedia.AutoSize = true;
            this.labelNotaMedia.Location = new System.Drawing.Point(238, 126);
            this.labelNotaMedia.Name = "labelNotaMedia";
            this.labelNotaMedia.Size = new System.Drawing.Size(67, 13);
            this.labelNotaMedia.TabIndex = 7;
            this.labelNotaMedia.Text = "Nota media: ";
            // 
            // labelNotaMediaResultado
            // 
            this.labelNotaMediaResultado.AutoSize = true;
            this.labelNotaMediaResultado.Location = new System.Drawing.Point(311, 126);
            this.labelNotaMediaResultado.Name = "labelNotaMediaResultado";
            this.labelNotaMediaResultado.Size = new System.Drawing.Size(13, 13);
            this.labelNotaMediaResultado.TabIndex = 8;
            this.labelNotaMediaResultado.Text = "0";
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(118, 55);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaNacimiento.TabIndex = 9;
            this.dateTimePickerFechaNacimiento.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePickerFechaNacimiento_Validating);
            // 
            // textBoxUsr
            // 
            this.textBoxUsr.Location = new System.Drawing.Point(36, 6);
            this.textBoxUsr.Name = "textBoxUsr";
            this.textBoxUsr.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsr.TabIndex = 10;
            this.textBoxUsr.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxUsr_Validating);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(183, 6);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxPass.TabIndex = 11;
            this.textBoxPass.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPass_Validating);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(68, 28);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 12;
            this.textBoxNombre.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNombre_Validating);
            // 
            // textBoxNota1
            // 
            this.textBoxNota1.Location = new System.Drawing.Point(92, 96);
            this.textBoxNota1.Name = "textBoxNota1";
            this.textBoxNota1.Size = new System.Drawing.Size(100, 20);
            this.textBoxNota1.TabIndex = 13;
            this.textBoxNota1.Leave += new System.EventHandler(this.actualizarMedia);
            // 
            // textBoxNota2
            // 
            this.textBoxNota2.Location = new System.Drawing.Point(92, 119);
            this.textBoxNota2.Name = "textBoxNota2";
            this.textBoxNota2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNota2.TabIndex = 14;
            this.textBoxNota2.Leave += new System.EventHandler(this.actualizarMedia);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(453, 13);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 15;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(453, 52);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 16;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 166);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxNota2);
            this.Controls.Add(this.textBoxNota1);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUsr);
            this.Controls.Add(this.dateTimePickerFechaNacimiento);
            this.Controls.Add(this.labelNotaMediaResultado);
            this.Controls.Add(this.labelNotaMedia);
            this.Controls.Add(this.labelNota2);
            this.Controls.Add(this.labelNota1);
            this.Controls.Add(this.labelNotas);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelUsr);
            this.Name = "Registro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsr;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelNotas;
        private System.Windows.Forms.Label labelNota1;
        private System.Windows.Forms.Label labelNota2;
        private System.Windows.Forms.Label labelNotaMedia;
        private System.Windows.Forms.Label labelNotaMediaResultado;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNacimiento;
        private System.Windows.Forms.TextBox textBoxUsr;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxNota1;
        private System.Windows.Forms.TextBox textBoxNota2;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonVolver;
    }
}