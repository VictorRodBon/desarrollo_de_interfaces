namespace Calculadora2
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
            this.boton0 = new System.Windows.Forms.Button();
            this.botonIgual = new System.Windows.Forms.Button();
            this.botonDiv = new System.Windows.Forms.Button();
            this.botonMult = new System.Windows.Forms.Button();
            this.botonRes = new System.Windows.Forms.Button();
            this.botonSum = new System.Windows.Forms.Button();
            this.botonCE = new System.Windows.Forms.Button();
            this.botonMasMenos = new System.Windows.Forms.Button();
            this.boton3 = new System.Windows.Forms.Button();
            this.boton2 = new System.Windows.Forms.Button();
            this.boton1 = new System.Windows.Forms.Button();
            this.boton6 = new System.Windows.Forms.Button();
            this.boton5 = new System.Windows.Forms.Button();
            this.boton4 = new System.Windows.Forms.Button();
            this.boton9 = new System.Windows.Forms.Button();
            this.boton8 = new System.Windows.Forms.Button();
            this.boton7 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.botonAc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botonAc);
            this.groupBox1.Controls.Add(this.boton0);
            this.groupBox1.Controls.Add(this.botonIgual);
            this.groupBox1.Controls.Add(this.botonDiv);
            this.groupBox1.Controls.Add(this.botonMult);
            this.groupBox1.Controls.Add(this.botonRes);
            this.groupBox1.Controls.Add(this.botonSum);
            this.groupBox1.Controls.Add(this.botonCE);
            this.groupBox1.Controls.Add(this.botonMasMenos);
            this.groupBox1.Controls.Add(this.boton3);
            this.groupBox1.Controls.Add(this.boton2);
            this.groupBox1.Controls.Add(this.boton1);
            this.groupBox1.Controls.Add(this.boton6);
            this.groupBox1.Controls.Add(this.boton5);
            this.groupBox1.Controls.Add(this.boton4);
            this.groupBox1.Controls.Add(this.boton9);
            this.groupBox1.Controls.Add(this.boton8);
            this.groupBox1.Controls.Add(this.boton7);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // boton0
            // 
            this.boton0.Location = new System.Drawing.Point(35, 106);
            this.boton0.Name = "boton0";
            this.boton0.Size = new System.Drawing.Size(23, 23);
            this.boton0.TabIndex = 17;
            this.boton0.Text = "0";
            this.boton0.UseVisualStyleBackColor = true;
            this.boton0.Click += new System.EventHandler(this.addToResult);
            // 
            // botonIgual
            // 
            this.botonIgual.Location = new System.Drawing.Point(35, 135);
            this.botonIgual.Name = "botonIgual";
            this.botonIgual.Size = new System.Drawing.Size(23, 23);
            this.botonIgual.TabIndex = 16;
            this.botonIgual.Text = "=";
            this.botonIgual.UseVisualStyleBackColor = true;
            this.botonIgual.Click += new System.EventHandler(this.botonIgual_Click);
            // 
            // botonDiv
            // 
            this.botonDiv.Location = new System.Drawing.Point(93, 106);
            this.botonDiv.Name = "botonDiv";
            this.botonDiv.Size = new System.Drawing.Size(23, 23);
            this.botonDiv.TabIndex = 15;
            this.botonDiv.Text = "/";
            this.botonDiv.UseVisualStyleBackColor = true;
            this.botonDiv.Click += new System.EventHandler(this.setNum1AndOpp);
            // 
            // botonMult
            // 
            this.botonMult.Location = new System.Drawing.Point(93, 77);
            this.botonMult.Name = "botonMult";
            this.botonMult.Size = new System.Drawing.Size(23, 23);
            this.botonMult.TabIndex = 14;
            this.botonMult.Text = "*";
            this.botonMult.UseVisualStyleBackColor = true;
            this.botonMult.Click += new System.EventHandler(this.setNum1AndOpp);
            // 
            // botonRes
            // 
            this.botonRes.Location = new System.Drawing.Point(93, 48);
            this.botonRes.Name = "botonRes";
            this.botonRes.Size = new System.Drawing.Size(23, 23);
            this.botonRes.TabIndex = 13;
            this.botonRes.Text = "-";
            this.botonRes.UseVisualStyleBackColor = true;
            this.botonRes.Click += new System.EventHandler(this.setNum1AndOpp);
            // 
            // botonSum
            // 
            this.botonSum.Location = new System.Drawing.Point(93, 19);
            this.botonSum.Name = "botonSum";
            this.botonSum.Size = new System.Drawing.Size(23, 23);
            this.botonSum.TabIndex = 12;
            this.botonSum.Text = "+";
            this.botonSum.UseVisualStyleBackColor = true;
            this.botonSum.Click += new System.EventHandler(this.setNum1AndOpp);
            // 
            // botonCE
            // 
            this.botonCE.Location = new System.Drawing.Point(64, 106);
            this.botonCE.Name = "botonCE";
            this.botonCE.Size = new System.Drawing.Size(23, 23);
            this.botonCE.TabIndex = 11;
            this.botonCE.Text = "7";
            this.botonCE.UseVisualStyleBackColor = true;
            // 
            // botonMasMenos
            // 
            this.botonMasMenos.Location = new System.Drawing.Point(6, 106);
            this.botonMasMenos.Name = "botonMasMenos";
            this.botonMasMenos.Size = new System.Drawing.Size(23, 52);
            this.botonMasMenos.TabIndex = 9;
            this.botonMasMenos.Text = "+/-";
            this.botonMasMenos.UseVisualStyleBackColor = true;
            this.botonMasMenos.Click += new System.EventHandler(this.addToResult);
            // 
            // boton3
            // 
            this.boton3.Location = new System.Drawing.Point(64, 77);
            this.boton3.Name = "boton3";
            this.boton3.Size = new System.Drawing.Size(23, 23);
            this.boton3.TabIndex = 8;
            this.boton3.Text = "3";
            this.boton3.UseVisualStyleBackColor = true;
            this.boton3.Click += new System.EventHandler(this.addToResult);
            // 
            // boton2
            // 
            this.boton2.Location = new System.Drawing.Point(35, 77);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(23, 23);
            this.boton2.TabIndex = 2;
            this.boton2.Text = "2";
            this.boton2.UseVisualStyleBackColor = true;
            this.boton2.Click += new System.EventHandler(this.addToResult);
            // 
            // boton1
            // 
            this.boton1.Location = new System.Drawing.Point(6, 77);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(23, 23);
            this.boton1.TabIndex = 6;
            this.boton1.Text = "1";
            this.boton1.UseVisualStyleBackColor = true;
            this.boton1.Click += new System.EventHandler(this.addToResult);
            // 
            // boton6
            // 
            this.boton6.Location = new System.Drawing.Point(64, 48);
            this.boton6.Name = "boton6";
            this.boton6.Size = new System.Drawing.Size(23, 23);
            this.boton6.TabIndex = 5;
            this.boton6.Text = "6";
            this.boton6.UseVisualStyleBackColor = true;
            this.boton6.Click += new System.EventHandler(this.addToResult);
            // 
            // boton5
            // 
            this.boton5.Location = new System.Drawing.Point(35, 48);
            this.boton5.Name = "boton5";
            this.boton5.Size = new System.Drawing.Size(23, 23);
            this.boton5.TabIndex = 4;
            this.boton5.Text = "5";
            this.boton5.UseVisualStyleBackColor = true;
            this.boton5.Click += new System.EventHandler(this.addToResult);
            // 
            // boton4
            // 
            this.boton4.Location = new System.Drawing.Point(6, 48);
            this.boton4.Name = "boton4";
            this.boton4.Size = new System.Drawing.Size(23, 23);
            this.boton4.TabIndex = 3;
            this.boton4.Text = "4";
            this.boton4.UseVisualStyleBackColor = true;
            this.boton4.Click += new System.EventHandler(this.addToResult);
            // 
            // boton9
            // 
            this.boton9.Location = new System.Drawing.Point(64, 19);
            this.boton9.Name = "boton9";
            this.boton9.Size = new System.Drawing.Size(23, 23);
            this.boton9.TabIndex = 2;
            this.boton9.Text = "9";
            this.boton9.UseVisualStyleBackColor = true;
            this.boton9.Click += new System.EventHandler(this.addToResult);
            // 
            // boton8
            // 
            this.boton8.Location = new System.Drawing.Point(35, 19);
            this.boton8.Name = "boton8";
            this.boton8.Size = new System.Drawing.Size(23, 23);
            this.boton8.TabIndex = 1;
            this.boton8.Text = "8";
            this.boton8.UseVisualStyleBackColor = true;
            this.boton8.Click += new System.EventHandler(this.addToResult);
            // 
            // boton7
            // 
            this.boton7.Location = new System.Drawing.Point(6, 19);
            this.boton7.Name = "boton7";
            this.boton7.Size = new System.Drawing.Size(23, 23);
            this.boton7.TabIndex = 0;
            this.boton7.Text = "7";
            this.boton7.UseVisualStyleBackColor = true;
            this.boton7.Click += new System.EventHandler(this.addToResult);
            // 
            // result
            // 
            this.result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result.Location = new System.Drawing.Point(18, 9);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(121, 13);
            this.result.TabIndex = 1;
            this.result.Text = "0";
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // botonAc
            // 
            this.botonAc.Location = new System.Drawing.Point(64, 135);
            this.botonAc.Name = "botonAc";
            this.botonAc.Size = new System.Drawing.Size(52, 23);
            this.botonAc.TabIndex = 18;
            this.botonAc.Text = "Ac";
            this.botonAc.UseVisualStyleBackColor = true;
            this.botonAc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.borrar);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(152, 198);
            this.Controls.Add(this.result);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botonIgual;
        private System.Windows.Forms.Button botonDiv;
        private System.Windows.Forms.Button botonMult;
        private System.Windows.Forms.Button botonRes;
        private System.Windows.Forms.Button botonSum;
        private System.Windows.Forms.Button botonCE;
        private System.Windows.Forms.Button botonMasMenos;
        private System.Windows.Forms.Button boton3;
        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Button boton6;
        private System.Windows.Forms.Button boton5;
        private System.Windows.Forms.Button boton4;
        private System.Windows.Forms.Button boton9;
        private System.Windows.Forms.Button boton8;
        private System.Windows.Forms.Button boton7;
        private System.Windows.Forms.Button boton0;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button botonAc;
    }
}

