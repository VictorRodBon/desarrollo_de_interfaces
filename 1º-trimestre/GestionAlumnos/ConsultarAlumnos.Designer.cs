namespace GestionAlumnos
{
    partial class ConsultarAlumnos
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
            this.ConsularAlumnos = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.labelAlumnos = new System.Windows.Forms.Label();
            this.textBoxCursoYGrupo = new System.Windows.Forms.TextBox();
            this.labelCurso = new System.Windows.Forms.Label();
            this.ConsularAlumnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsularAlumnos
            // 
            this.ConsularAlumnos.Controls.Add(this.textBox1);
            this.ConsularAlumnos.Controls.Add(this.buttonVolver);
            this.ConsularAlumnos.Controls.Add(this.labelAlumnos);
            this.ConsularAlumnos.Controls.Add(this.textBoxCursoYGrupo);
            this.ConsularAlumnos.Controls.Add(this.labelCurso);
            this.ConsularAlumnos.Location = new System.Drawing.Point(14, 10);
            this.ConsularAlumnos.Name = "ConsularAlumnos";
            this.ConsularAlumnos.Size = new System.Drawing.Size(374, 207);
            this.ConsularAlumnos.TabIndex = 0;
            this.ConsularAlumnos.TabStop = false;
            this.ConsularAlumnos.Text = "Consultar Alumnos por Curso y Grupo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(291, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 20);
            this.textBox1.TabIndex = 4;
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(15, 172);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(115, 22);
            this.buttonVolver.TabIndex = 3;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // labelAlumnos
            // 
            this.labelAlumnos.AutoSize = true;
            this.labelAlumnos.Location = new System.Drawing.Point(73, 48);
            this.labelAlumnos.Name = "labelAlumnos";
            this.labelAlumnos.Size = new System.Drawing.Size(16, 13);
            this.labelAlumnos.TabIndex = 2;
            this.labelAlumnos.Text = "...";
            // 
            // textBoxCursoYGrupo
            // 
            this.textBoxCursoYGrupo.Location = new System.Drawing.Point(76, 16);
            this.textBoxCursoYGrupo.Name = "textBoxCursoYGrupo";
            this.textBoxCursoYGrupo.Size = new System.Drawing.Size(196, 20);
            this.textBoxCursoYGrupo.TabIndex = 1;
            this.textBoxCursoYGrupo.Leave += new System.EventHandler(this.consultarAlumnos);
            // 
            // labelCurso
            // 
            this.labelCurso.AutoSize = true;
            this.labelCurso.Location = new System.Drawing.Point(6, 16);
            this.labelCurso.Name = "labelCurso";
            this.labelCurso.Size = new System.Drawing.Size(37, 13);
            this.labelCurso.TabIndex = 0;
            this.labelCurso.Text = "Curso:";
            // 
            // ConsultarAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 231);
            this.Controls.Add(this.ConsularAlumnos);
            this.Name = "ConsultarAlumnos";
            this.Text = "ConsultarAlumnos";
            this.ConsularAlumnos.ResumeLayout(false);
            this.ConsularAlumnos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ConsularAlumnos;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Label labelAlumnos;
        private System.Windows.Forms.TextBox textBoxCursoYGrupo;
        private System.Windows.Forms.Label labelCurso;
        private System.Windows.Forms.TextBox textBox1;
    }
}