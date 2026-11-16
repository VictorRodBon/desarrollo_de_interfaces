using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen
{
    public partial class DatosUsuario : Form
    {
        public DatosUsuario(Alumno alumno)
        {
            InitializeComponent();

            labelUsrText.Text = alumno.usr;
            labelPassText.Text = alumno.pass;
            labelNombreText.Text = alumno.nombre;
            labelNotaMediaText.Text = alumno.notaMedia.ToString();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
