using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAlumnos
{
    public partial class MatricularAlumno : Form
    {
        private ErrorProvider errorProvider1 = new ErrorProvider();
        public Alumno alumnoNuevo { get; private set; }

        public MatricularAlumno()
        {
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Por favor, corrige los errores antes de guardar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            alumnoNuevo = new Alumno
            {
                Nombre = textNombre.Text,
                Dni = textDni.Text,
                Curso = textCurso.Text,
                Grupo = textGrupo.Text.ToUpper()
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textNombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textNombre.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textNombre, "El nombre no puede estar vacío.");
            }
            else if (textNombre.Text.Length >= 15)
            {
                e.Cancel = true;
                errorProvider1.SetError(textNombre, "El nombre debe tener menos de 15 caracteres.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textNombre, string.Empty);
            }
        }
        private void textDni_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Llamamos a la función de comprobación
            if (!ValidarDNI(textDni.Text))
            {
                e.Cancel = true; // Bloquea el foco si el DNI es incorrecto
                errorProvider1.SetError(textDni, "DNI no válido (introduce 8 números y su letra correcta).");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textDni, string.Empty);
            }
        }

        private void textCurso_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // 1. Definir los valores permitidos
            string[] cursosValidos = { "1", "2" };

            // 2. Limpiar o formatear el texto del usuario (ej: pasar a mayúsculas y quitar espacios)
            string cursoIngresado = textCurso.Text.Trim().ToUpper();

            // 3. Comprobar si el texto está dentro del array (requiere usar System.Linq)
            bool esValido = cursosValidos.Contains(cursoIngresado);

            if (string.IsNullOrWhiteSpace(cursoIngresado) || !esValido)
            {
                e.Cancel = true; // Bloquea el foco si no es válido
                errorProvider1.SetError(textCurso, "Curso no válido. Opciones permitidas: 1ESO, 2ESO, 3ESO, 4ESO, 1BACH, 2BACH.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textCurso, string.Empty);
            }
        }

        private void textGrupo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // 1. Definir los valores permitidos
            string[] cursosValidos = { "A", "B" };

            // 2. Limpiar o formatear el texto del usuario (ej: pasar a mayúsculas y quitar espacios)
            string cursoIngresado = textGrupo.Text.Trim().ToUpper();

            // 3. Comprobar si el texto está dentro del array (requiere usar System.Linq)
            bool esValido = cursosValidos.Contains(cursoIngresado);

            if (string.IsNullOrWhiteSpace(cursoIngresado) || !esValido)
            {
                e.Cancel = true; // Bloquea el foco si no es válido
                errorProvider1.SetError(textGrupo, "Grupo no válido. Opciones permitidas: A, B.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textGrupo, string.Empty);
            }
        }

        private bool ValidarDNI(string dni)
        {
            // Comprobar longitud básica (8 números + 1 letra = 9 caracteres)
            if (string.IsNullOrWhiteSpace(dni) || dni.Length != 9)
            {
                return false;
            }

            string numeroStr = dni.Substring(0, 8);
            char letraDni = char.ToUpper(dni[8]);

            // Comprobar que los primeros 8 caracteres sean números
            if (!int.TryParse(numeroStr, out int numero))
            {
                return false;
            }

            // Tabla de letras oficiales del DNI en España
            string juegoCaracteres = "TRWAGMYFPDXBNJZSQVHLCKE";
            char letraCalculada = juegoCaracteres[numero % 23];

            // Verificar si la letra introducida coincide con la calculada
            return letraDni == letraCalculada;
        }
    }
}
