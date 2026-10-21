namespace BilleteAutobus
{
    partial class comprarBillete
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
            this.labelDni = new System.Windows.Forms.Label();
            this.labelPlaza = new System.Windows.Forms.Label();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.comboBoxPlaza = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Location = new System.Drawing.Point(12, 9);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(29, 13);
            this.labelDni.TabIndex = 0;
            this.labelDni.Text = "DNI:";
            // 
            // labelPlaza
            // 
            this.labelPlaza.AutoSize = true;
            this.labelPlaza.Location = new System.Drawing.Point(12, 39);
            this.labelPlaza.Name = "labelPlaza";
            this.labelPlaza.Size = new System.Drawing.Size(36, 13);
            this.labelPlaza.TabIndex = 1;
            this.labelPlaza.Text = "Plaza:";
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(84, 6);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(130, 20);
            this.textBoxDni.TabIndex = 2;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(84, 83);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 4;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // comboBoxPlaza
            // 
            this.comboBoxPlaza.FormattingEnabled = true;
            this.comboBoxPlaza.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxPlaza.Location = new System.Drawing.Point(84, 37);
            this.comboBoxPlaza.Name = "comboBoxPlaza";
            this.comboBoxPlaza.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPlaza.TabIndex = 5;
            // 
            // comprarBillete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 118);
            this.Controls.Add(this.comboBoxPlaza);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxDni);
            this.Controls.Add(this.labelPlaza);
            this.Controls.Add(this.labelDni);
            this.Name = "comprarBillete";
            this.Text = "comprarBillete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.Label labelPlaza;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.ComboBox comboBoxPlaza;
    }
}