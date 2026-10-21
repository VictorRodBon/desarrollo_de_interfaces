using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BilleteAutobus
{
    public partial class comprarBillete : Form
    {
        private List<Cliente> listaClientes;

        public comprarBillete(List<Cliente> listaClientes)
        {
            InitializeComponent();
            this.listaClientes = listaClientes;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            // 1. Buscar si el cliente existe por su DNI
            Cliente clienteExistente = ObtenerClientePorDni(textBoxDni.Text);

            if (clienteExistente == null)
            {
                MessageBox.Show(
                    "El DNI introducido no corresponde a ningún cliente registrado.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // 2. Validar que el asiento seleccionado esté libre
            if (ComprobarAsientoOcupado(comboBoxPlaza.Text))
            {
                MessageBox.Show(
                    "El asiento introducido está ocupado. Por favor, seleccione otro.",
                    "Error al escoger asiento",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // 3. Modificar el asiento del cliente encontrado
            if (int.TryParse(comboBoxPlaza.Text, out int asientoNumerico))
            {
                // Modificamos directamente el objeto que ya está dentro de la lista
                clienteExistente.Plaza = asientoNumerico;

                MessageBox.Show("¡Asiento modificado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("El formato del asiento no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cambiado: Ahora devuelve el objeto Cliente completo o 'null' si no existe
        private Cliente ObtenerClientePorDni(string dni)
        {
            foreach (var cliente in listaClientes)
            {
                if (cliente.Dni == dni)
                {
                    return cliente; // Devuelve la referencia al cliente encontrado
                }
            }
            return null; // Si no lo encuentra, devuelve null
        }

        private bool ComprobarAsientoOcupado(string asiento)
        {
            if (int.TryParse(asiento, out int plaza))
            {
                foreach (var cliente in listaClientes)
                {
                    if (cliente.Plaza == plaza)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
