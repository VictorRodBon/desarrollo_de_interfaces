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
    public partial class consultarClientes : Form
    {
        private List<Cliente> listaClientes;
        public consultarClientes(List<Cliente> listaClientes)
        {
            InitializeComponent();
            this.listaClientes = listaClientes;

            MostrarClientes();
        }

        private void MostrarClientes()
        {
            flowLayoutPanel1.Controls.Clear();

            if (listaClientes == null || listaClientes.Count == 0)
            {
                Label lblVacio = new Label();
                lblVacio.Text = "no hay clientes registrados";
                lblVacio.AutoSize = true;
                flowLayoutPanel1.Controls.Add(lblVacio);
                
                return;
            }

            foreach (var item in listaClientes)
            {
                Label lblCliente = new Label();

                lblCliente.Text += "DNI: " + item.Dni + " | Plaza:"+ item.Plaza + "\r\n";

                lblCliente.AutoSize = true;
                lblCliente.Font = new Font("Arial", 10, FontStyle.Regular);
                lblCliente.Padding = new Padding(5, 5, 5, 5);
                lblCliente.Margin = new Padding(0, 0, 0, 10); // Separación con el siguiente label

                flowLayoutPanel1.Controls.Add(lblCliente);
            }
        }
    }
}
