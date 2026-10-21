namespace BilleteAutobus
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
            this.altaUsuario = new System.Windows.Forms.Button();
            this.comprarBillete = new System.Windows.Forms.Button();
            this.comprobarUsuarios = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // altaUsuario
            // 
            this.altaUsuario.Location = new System.Drawing.Point(13, 13);
            this.altaUsuario.Name = "altaUsuario";
            this.altaUsuario.Size = new System.Drawing.Size(263, 23);
            this.altaUsuario.TabIndex = 0;
            this.altaUsuario.Text = "Alta usuario";
            this.altaUsuario.UseVisualStyleBackColor = true;
            this.altaUsuario.Click += new System.EventHandler(this.altaUsuario_Click);
            // 
            // comprarBillete
            // 
            this.comprarBillete.Location = new System.Drawing.Point(13, 55);
            this.comprarBillete.Name = "comprarBillete";
            this.comprarBillete.Size = new System.Drawing.Size(263, 23);
            this.comprarBillete.TabIndex = 1;
            this.comprarBillete.Text = "Comprar billete";
            this.comprarBillete.UseVisualStyleBackColor = true;
            this.comprarBillete.Click += new System.EventHandler(this.comprarBillete_Click);
            // 
            // comprobarUsuarios
            // 
            this.comprobarUsuarios.Location = new System.Drawing.Point(13, 97);
            this.comprobarUsuarios.Name = "comprobarUsuarios";
            this.comprobarUsuarios.Size = new System.Drawing.Size(263, 23);
            this.comprobarUsuarios.TabIndex = 2;
            this.comprobarUsuarios.Text = "Comprobar usuarios";
            this.comprobarUsuarios.UseVisualStyleBackColor = true;
            this.comprobarUsuarios.Click += new System.EventHandler(this.comprobarUsuarios_Click);
            // 
            // cerrar
            // 
            this.cerrar.Location = new System.Drawing.Point(13, 140);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(263, 23);
            this.cerrar.TabIndex = 3;
            this.cerrar.Text = "Cerrar";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 181);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.comprobarUsuarios);
            this.Controls.Add(this.comprarBillete);
            this.Controls.Add(this.altaUsuario);
            this.Name = "Form1";
            this.Text = "Programa billetes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button altaUsuario;
        private System.Windows.Forms.Button comprarBillete;
        private System.Windows.Forms.Button comprobarUsuarios;
        private System.Windows.Forms.Button cerrar;
    }
}

