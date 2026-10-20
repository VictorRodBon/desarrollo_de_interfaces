using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilleteAutobus
{
    public partial class nuevoCliente : Form
    {
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
            cliente.Telefono = int.Parse(textBoxTelefono.Text);

            // Indicamos que la operación fue exitosa y cerramos el formulario
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
