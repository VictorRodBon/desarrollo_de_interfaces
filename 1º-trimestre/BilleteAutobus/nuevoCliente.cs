using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilleteAutobus
{
    public partial class nuevoCliente : Form
    {
        private static readonly string juegoCaracteres = "TRWAGMYFPDXBNJZSQVHLCKE";
        public Cliente cliente { get; private set; }
        public nuevoCliente()
        {
            InitializeComponent();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            // Guardamos el valor en la propiedad
            cliente = new Cliente();
            cliente.Dni = textBoxDni.Text;
            cliente.Nombre = textBoxNombre.Text;
            cliente.Correo = textBoxCorreo.Text;
            cliente.Telefono = textBoxTelefono.Text;
            cliente.Plaza = 0;

            // validamos el DNI
            if (!validarDni(cliente.Dni))
            {
                MessageBox.Show(
                    "El DNI introducido no es válido. Por favor, inténtelo de nuevo",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                // Indicamos que la operación fue exitosa y cerramos el formulario
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cancelar_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool validarDni(String dni) {
            if (string.IsNullOrWhiteSpace(dni)) return false;

            // Formato: 8 números y 1 letra (mayúscula o minúscula)
            if (!Regex.IsMatch(dni, @"^[0-9]{8}[A-Za-z]$")) return false;

            int numero = int.Parse(dni.Substring(0, 8));
            char letraCalculada = juegoCaracteres[numero % 23];
            char letraProporcionada = char.ToUpper(dni[8]);

            return letraCalculada == letraProporcionada;
        }
    }
}
