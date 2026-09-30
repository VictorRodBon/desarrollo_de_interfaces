namespace MiniCalculadora
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
            this.Calcular = new System.Windows.Forms.Button();
            this.ResultadoDivision = new System.Windows.Forms.Label();
            this.ResultadoMultiplicacion = new System.Windows.Forms.Label();
            this.ResultadoResta = new System.Windows.Forms.Label();
            this.ResultadoSuma = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Division2 = new System.Windows.Forms.TextBox();
            this.Division1 = new System.Windows.Forms.TextBox();
            this.Multiplicacion2 = new System.Windows.Forms.TextBox();
            this.Multiplicacion1 = new System.Windows.Forms.TextBox();
            this.Resta2 = new System.Windows.Forms.TextBox();
            this.Resta1 = new System.Windows.Forms.TextBox();
            this.Suma2 = new System.Windows.Forms.TextBox();
            this.Suma1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Calcular);
            this.groupBox1.Controls.Add(this.ResultadoDivision);
            this.groupBox1.Controls.Add(this.ResultadoMultiplicacion);
            this.groupBox1.Controls.Add(this.ResultadoResta);
            this.groupBox1.Controls.Add(this.ResultadoSuma);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Division2);
            this.groupBox1.Controls.Add(this.Division1);
            this.groupBox1.Controls.Add(this.Multiplicacion2);
            this.groupBox1.Controls.Add(this.Multiplicacion1);
            this.groupBox1.Controls.Add(this.Resta2);
            this.groupBox1.Controls.Add(this.Resta1);
            this.groupBox1.Controls.Add(this.Suma2);
            this.groupBox1.Controls.Add(this.Suma1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calcular";
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(18, 124);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 23);
            this.Calcular.TabIndex = 20;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // ResultadoDivision
            // 
            this.ResultadoDivision.AutoSize = true;
            this.ResultadoDivision.Location = new System.Drawing.Point(261, 101);
            this.ResultadoDivision.Name = "ResultadoDivision";
            this.ResultadoDivision.Size = new System.Drawing.Size(55, 13);
            this.ResultadoDivision.TabIndex = 19;
            this.ResultadoDivision.Text = "Resultado";
            // 
            // ResultadoMultiplicacion
            // 
            this.ResultadoMultiplicacion.AutoSize = true;
            this.ResultadoMultiplicacion.Location = new System.Drawing.Point(260, 72);
            this.ResultadoMultiplicacion.Name = "ResultadoMultiplicacion";
            this.ResultadoMultiplicacion.Size = new System.Drawing.Size(55, 13);
            this.ResultadoMultiplicacion.TabIndex = 18;
            this.ResultadoMultiplicacion.Text = "Resultado";
            // 
            // ResultadoResta
            // 
            this.ResultadoResta.AutoSize = true;
            this.ResultadoResta.Location = new System.Drawing.Point(261, 46);
            this.ResultadoResta.Name = "ResultadoResta";
            this.ResultadoResta.Size = new System.Drawing.Size(55, 13);
            this.ResultadoResta.TabIndex = 17;
            this.ResultadoResta.Text = "Resultado";
            // 
            // ResultadoSuma
            // 
            this.ResultadoSuma.AutoSize = true;
            this.ResultadoSuma.Location = new System.Drawing.Point(261, 23);
            this.ResultadoSuma.Name = "ResultadoSuma";
            this.ResultadoSuma.Size = new System.Drawing.Size(55, 13);
            this.ResultadoSuma.TabIndex = 16;
            this.ResultadoSuma.Text = "Resultado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "+";
            // 
            // Division2
            // 
            this.Division2.Location = new System.Drawing.Point(137, 98);
            this.Division2.Name = "Division2";
            this.Division2.Size = new System.Drawing.Size(100, 20);
            this.Division2.TabIndex = 7;
            // 
            // Division1
            // 
            this.Division1.Location = new System.Drawing.Point(7, 98);
            this.Division1.Name = "Division1";
            this.Division1.Size = new System.Drawing.Size(100, 20);
            this.Division1.TabIndex = 6;
            // 
            // Multiplicacion2
            // 
            this.Multiplicacion2.Location = new System.Drawing.Point(137, 72);
            this.Multiplicacion2.Name = "Multiplicacion2";
            this.Multiplicacion2.Size = new System.Drawing.Size(100, 20);
            this.Multiplicacion2.TabIndex = 5;
            // 
            // Multiplicacion1
            // 
            this.Multiplicacion1.Location = new System.Drawing.Point(7, 72);
            this.Multiplicacion1.Name = "Multiplicacion1";
            this.Multiplicacion1.Size = new System.Drawing.Size(100, 20);
            this.Multiplicacion1.TabIndex = 4;
            // 
            // Resta2
            // 
            this.Resta2.Location = new System.Drawing.Point(136, 46);
            this.Resta2.Name = "Resta2";
            this.Resta2.Size = new System.Drawing.Size(100, 20);
            this.Resta2.TabIndex = 3;
            // 
            // Resta1
            // 
            this.Resta1.Location = new System.Drawing.Point(6, 46);
            this.Resta1.Name = "Resta1";
            this.Resta1.Size = new System.Drawing.Size(100, 20);
            this.Resta1.TabIndex = 2;
            // 
            // Suma2
            // 
            this.Suma2.Location = new System.Drawing.Point(137, 20);
            this.Suma2.Name = "Suma2";
            this.Suma2.Size = new System.Drawing.Size(100, 20);
            this.Suma2.TabIndex = 1;
            // 
            // Suma1
            // 
            this.Suma1.Location = new System.Drawing.Point(7, 20);
            this.Suma1.Name = "Suma1";
            this.Suma1.Size = new System.Drawing.Size(100, 20);
            this.Suma1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Division2;
        private System.Windows.Forms.TextBox Division1;
        private System.Windows.Forms.TextBox Multiplicacion2;
        private System.Windows.Forms.TextBox Multiplicacion1;
        private System.Windows.Forms.TextBox Resta2;
        private System.Windows.Forms.TextBox Resta1;
        private System.Windows.Forms.TextBox Suma2;
        private System.Windows.Forms.TextBox Suma1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ResultadoSuma;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label ResultadoDivision;
        private System.Windows.Forms.Label ResultadoMultiplicacion;
        private System.Windows.Forms.Label ResultadoResta;
    }
}

