namespace FormularioConWebView
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
            this.labelPagina = new System.Windows.Forms.Label();
            this.textUrl = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPagina
            // 
            this.labelPagina.AutoSize = true;
            this.labelPagina.Location = new System.Drawing.Point(12, 9);
            this.labelPagina.Name = "labelPagina";
            this.labelPagina.Size = new System.Drawing.Size(40, 13);
            this.labelPagina.TabIndex = 0;
            this.labelPagina.Text = "Página";
            // 
            // textUrl
            // 
            this.textUrl.Location = new System.Drawing.Point(59, 9);
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(680, 20);
            this.textUrl.TabIndex = 1;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(745, 7);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(28, 23);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.Text = "IR";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(1, 80);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(799, 358);
            this.webView.Source = new System.Uri("https://site.educa.madrid.org/ies.elcanaveral.mostoles/", System.UriKind.Absolute);
            this.webView.TabIndex = 3;
            this.webView.ZoomFactor = 1D;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textUrl);
            this.Controls.Add(this.labelPagina);
            this.Name = "Form1";
            this.Text = "Navegador";
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPagina;
        private System.Windows.Forms.TextBox textUrl;
        private System.Windows.Forms.Button buttonBuscar;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
    }
}

