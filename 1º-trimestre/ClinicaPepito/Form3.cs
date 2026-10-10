using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaPepito
{
    public partial class ConsultarCitas : Form
    {
    private NuevaCita _formularioCitas;
        public ConsultarCitas(NuevaCita instanciaForm2)
        {
            InitializeComponent();
            _formularioCitas = instanciaForm2;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (_formularioCitas == null)
            {
                labelFechaCita.Text = "Primero debes abrir el formulario de Nueva Cita.";
                return;
            }

            string clienteABuscar = numeroCliente.Text;
            string fechaEncontrada = _formularioCitas.ObtenerFechaCita(clienteABuscar);

            if (fechaEncontrada != null)
            {
                labelFechaCita.Text = $"Cita encontrada el: {fechaEncontrada}";
            }
            else
            {
                labelFechaCita.Text = "No se encontró ninguna cita para este cliente.";
            }
        }

    }
}
