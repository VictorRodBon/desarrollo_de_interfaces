using System;
using System.Windows.Forms;

namespace ClinicaPepito
{

    public partial class Form1 : Form
    {
        private NuevaCita _instanciaForm2;

        public Form1()
        {
            InitializeComponent();
        }

        private void botonNuevaCita_Click(object sender, EventArgs e)
        {
            if (_instanciaForm2 == null || _instanciaForm2.IsDisposed)
            {
                _instanciaForm2 = new NuevaCita();
            }
            _instanciaForm2.Show();
        }

        private void botonConsultarCita_Click(object sender, EventArgs e)
        {
            ConsultarCitas f3 = new ConsultarCitas(_instanciaForm2);
            f3.Show();
        }

        
    }

}