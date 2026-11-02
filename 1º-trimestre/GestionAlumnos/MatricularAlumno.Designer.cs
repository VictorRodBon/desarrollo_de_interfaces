namespace GestionAlumnos
{
    partial class MatricularAlumno
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.textGrupo = new System.Windows.Forms.TextBox();
            this.textCurso = new System.Windows.Forms.TextBox();
            this.textDni = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.labelLetra = new System.Windows.Forms.Label();
            this.labelCurso = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCancelar);
            this.groupBox1.Controls.Add(this.buttonAceptar);
            this.groupBox1.Controls.Add(this.textGrupo);
            this.groupBox1.Controls.Add(this.textCurso);
            this.groupBox1.Controls.Add(this.textDni);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.labelLetra);
            this.groupBox1.Controls.Add(this.labelCurso);
            this.groupBox1.Controls.Add(this.labelDNI);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Location = new System.Drawing.Point(13, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matricular Alumno Nuevo";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonCancelar.Location = new System.Drawing.Point(111, 136);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonAceptar.Location = new System.Drawing.Point(6, 136);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 1;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // textGrupo
            // 
            this.textGrupo.Location = new System.Drawing.Point(87, 96);
            this.textGrupo.Name = "textGrupo";
            this.textGrupo.Size = new System.Drawing.Size(99, 20);
            this.textGrupo.TabIndex = 7;
            this.textGrupo.Validating += new System.ComponentModel.CancelEventHandler(this.textGrupo_Validating);
            // 
            // textCurso
            // 
            this.textCurso.Location = new System.Drawing.Point(87, 70);
            this.textCurso.Name = "textCurso";
            this.textCurso.Size = new System.Drawing.Size(99, 20);
            this.textCurso.TabIndex = 6;
            // 
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(87, 44);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(99, 20);
            this.textDni.TabIndex = 5;
            this.textDni.Validating += new System.ComponentModel.CancelEventHandler(this.textDni_Validating);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(87, 18);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(99, 20);
            this.textNombre.TabIndex = 4;
            this.textNombre.Validating += new System.ComponentModel.CancelEventHandler(this.textNombre_Validating);
            // 
            // labelLetra
            // 
            this.labelLetra.AutoSize = true;
            this.labelLetra.Location = new System.Drawing.Point(6, 99);
            this.labelLetra.Name = "labelLetra";
            this.labelLetra.Size = new System.Drawing.Size(37, 13);
            this.labelLetra.TabIndex = 3;
            this.labelLetra.Text = "Letra: ";
            // 
            // labelCurso
            // 
            this.labelCurso.AutoSize = true;
            this.labelCurso.Location = new System.Drawing.Point(6, 73);
            this.labelCurso.Name = "labelCurso";
            this.labelCurso.Size = new System.Drawing.Size(37, 13);
            this.labelCurso.TabIndex = 2;
            this.labelCurso.Text = "Curso:";
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(6, 47);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(32, 13);
            this.labelDNI.TabIndex = 1;
            this.labelDNI.Text = "DNI: ";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(6, 21);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(50, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre: ";
            // 
            // MatricularAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 207);
            this.Controls.Add(this.groupBox1);
            this.Name = "MatricularAlumno";
            this.Text = "MatricularAlumno";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelLetra;
        private System.Windows.Forms.Label labelCurso;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.TextBox textGrupo;
        private System.Windows.Forms.TextBox textCurso;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.TextBox textNombre;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}