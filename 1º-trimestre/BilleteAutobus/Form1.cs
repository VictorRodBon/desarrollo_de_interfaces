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
            formularioNuevoCliente.ShowDialog();
        }

        private void comprobarUsuarios_Click(object sender, EventArgs e)
        {
            consultarClientes formularioConsultarClientes = new consultarClientes(list);
        }
    }
}
