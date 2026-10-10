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
    public partial class NuevaCita : Form
    {
        private string[,] _citas = new string[100, 2];
        private int _contador = 0;

        public NuevaCita()
        {
            InitializeComponent();
        }

        private void btnGuardarCita_Click(object sender, EventArgs e)
        {
            if (_contador < _citas.GetLength(0))
            {
                _citas[_contador, 0] = numeroPaciente.Text;

                _citas[_contador, 1] = fechaCita.Value.ToString("dd/MM/yyyy");

                _contador++;
                MessageBox.Show($"Cita guardada con éxito para el día: {fechaCita.Value.ToString("dd/MM/yyyy")}");

                numeroPaciente.Clear();
            }
            else
            {
                MessageBox.Show("El registro de citas está lleno.");
            }
        }


        public string ObtenerFechaCita(string numCliente)
        {
            for (int i = 0; i < _contador; i++)
            {
                if (_citas[i, 0] == numCliente)
                {
                    return _citas[i, 1];
                }
            }
            return null;
        }
    }
}