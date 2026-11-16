using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen
{
    public partial class Registro : Form
    {
        public Alumno alumno { get; private set; }

        public Registro()
        {
            InitializeComponent();
        }

        private void textBoxUsr_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            string usr = textBoxUsr.Text.Trim();
            if (string.IsNullOrWhiteSpace(usr) || usr.Length > 5)
            {
                errorProvider1.SetError(textBoxUsr, "Usuario no válido (longitud maxima de 5 caracteres) ");
            }
        }

        private void textBoxPass_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            string usr = textBoxPass.Text.Trim();
            if (string.IsNullOrWhiteSpace(usr) || usr.Length > 6)
            {
                errorProvider1.SetError(textBoxPass, "Password no válido (longitud maxima de 6 caracteres) ");
            }
        }

        private void textBoxNombre_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            string usr = textBoxNombre.Text.Trim();
            if (string.IsNullOrWhiteSpace(usr))
            {
                errorProvider1.SetError(textBoxNombre, "El nombre no puede estar vacío");
            }
        }

        private void dateTimePickerFechaNacimiento_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            DateTime nacimiento = dateTimePickerFechaNacimiento.Value;

            TimeSpan diferencia = nacimiento - DateTime.Now;
            if (diferencia.Days/365.25 < 18)
            {
                errorProvider1.SetError(dateTimePickerFechaNacimiento, "Registro solo permitido a usuarios mayores de edad ");
            }
        }

        public int calcularMedia()
        {
            int.TryParse(textBoxNota1.Text.Trim(), out int nota1);
            int.TryParse(textBoxNota2.Text.Trim(), out int nota2);
            return (nota1+nota2)/2;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                MessageBox.Show("Por favor, corrige los errores antes de guardar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                alumno = new Alumno
                {
                    usr = textBoxUsr.Text,
                    nombre = textBoxNombre.Text,
                    pass = textBoxPass.Text,
                    fecha = dateTimePickerFechaNacimiento.Value,
                    notaMedia = calcularMedia()

                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void actualizarMedia(object sender, EventArgs e)
        {
            labelNotaMediaResultado.Text=calcularMedia().ToString();
        }

        
    }
}
