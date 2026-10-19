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
        }
    }
}
