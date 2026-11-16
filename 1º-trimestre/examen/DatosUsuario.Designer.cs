namespace examen
{
    partial class DatosUsuario
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
            this.labelPass = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelNotas = new System.Windows.Forms.Label();
            this.labelNotaMedia = new System.Windows.Forms.Label();
            this.labelNotaMediaText = new System.Windows.Forms.Label();
            this.labelNombreText = new System.Windows.Forms.Label();
            this.labelPassText = new System.Windows.Forms.Label();
            this.labelUsrText = new System.Windows.Forms.Label();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUsr
            // 
            this.labelUsr.AutoSize = true;
            this.labelUsr.Location = new System.Drawing.Point(12, 9);
            this.labelUsr.Name = "labelUsr";
            this.labelUsr.Size = new System.Drawing.Size(26, 13);
            this.labelUsr.TabIndex = 0;
            this.labelUsr.Text = "Usr:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(384, 9);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(33, 13);
            this.labelPass.TabIndex = 1;
            this.labelPass.Text = "Pass:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(12, 38);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelNotas
            // 
            this.labelNotas.AutoSize = true;
            this.labelNotas.Location = new System.Drawing.Point(12, 89);
            this.labelNotas.Name = "labelNotas";
            this.labelNotas.Size = new System.Drawing.Size(38, 13);
            this.labelNotas.TabIndex = 3;
            this.labelNotas.Text = "Notas:";
            // 
            // labelNotaMedia
            // 
            this.labelNotaMedia.AutoSize = true;
            this.labelNotaMedia.Location = new System.Drawing.Point(21, 119);
            this.labelNotaMedia.Name = "labelNotaMedia";
            this.labelNotaMedia.Size = new System.Drawing.Size(65, 13);
            this.labelNotaMedia.TabIndex = 4;
            this.labelNotaMedia.Text = "Nota Media:";
            // 
            // labelNotaMediaText
            // 
            this.labelNotaMediaText.AutoSize = true;
            this.labelNotaMediaText.Location = new System.Drawing.Point(119, 119);
            this.labelNotaMediaText.Name = "labelNotaMediaText";
            this.labelNotaMediaText.Size = new System.Drawing.Size(65, 13);
            this.labelNotaMediaText.TabIndex = 5;
            this.labelNotaMediaText.Text = "Nota Media:";
            // 
            // labelNombreText
            // 
            this.labelNombreText.AutoSize = true;
            this.labelNombreText.Location = new System.Drawing.Point(75, 38);
            this.labelNombreText.Name = "labelNombreText";
            this.labelNombreText.Size = new System.Drawing.Size(65, 13);
            this.labelNombreText.TabIndex = 6;
            this.labelNombreText.Text = "Nota Media:";
            // 
            // labelPassText
            // 
            this.labelPassText.AutoSize = true;
            this.labelPassText.Location = new System.Drawing.Point(423, 9);
            this.labelPassText.Name = "labelPassText";
            this.labelPassText.Size = new System.Drawing.Size(65, 13);
            this.labelPassText.TabIndex = 7;
            this.labelPassText.Text = "Nota Media:";
            // 
            // labelUsrText
            // 
            this.labelUsrText.AutoSize = true;
            this.labelUsrText.Location = new System.Drawing.Point(54, 9);
            this.labelUsrText.Name = "labelUsrText";
            this.labelUsrText.Size = new System.Drawing.Size(65, 13);
            this.labelUsrText.TabIndex = 8;
            this.labelUsrText.Text = "Nota Media:";
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(401, 114);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 9;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // DatosUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.labelUsrText);
            this.Controls.Add(this.labelPassText);
            this.Controls.Add(this.labelNombreText);
            this.Controls.Add(this.labelNotaMediaText);
            this.Controls.Add(this.labelNotaMedia);
            this.Controls.Add(this.labelNotas);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelUsr);
            this.Name = "DatosUsuario";
            this.Text = "DatosUsuariuo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsr;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelNotas;
        private System.Windows.Forms.Label labelNotaMedia;
        private System.Windows.Forms.Label labelNotaMediaText;
        private System.Windows.Forms.Label labelNombreText;
        private System.Windows.Forms.Label labelPassText;
        private System.Windows.Forms.Label labelUsrText;
        private System.Windows.Forms.Button buttonVolver;
    }
}