using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BilleteAutobus
{
    public partial class Form1 : Form
    {
        List<Cliente> listaClientes = new List<Cliente>();

        public Form1()
        {
            InitializeComponent();
        }

        private void altaUsuario_Click(object sender, EventArgs e)
        {
            nuevoCliente formularioNuevoCliente = new nuevoCliente();
            
            if(formularioNuevoCliente.ShowDialog() == DialogResult.OK)
            {
                listaClientes.Add(formularioNuevoCliente.cliente);
            }
        }

        private void comprobarUsuarios_Click(object sender, EventArgs e)
        {
            consultarClientes formularioConsultarClientes = new consultarClientes(listaClientes);
            formularioConsultarClientes.Show();
        }

        private void comprarBillete_Click(object sender, EventArgs e)
        {
            comprarBillete formularioComprarBillete = new comprarBillete(listaClientes);
            formularioComprarBillete.Show();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
