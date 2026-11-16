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
    public partial class Acceso : Form
    {
        List<Alumno> listaAlumnos = new List<Alumno>();
        
        public Acceso()
        {
            InitializeComponent();

            labelUsuariosRegistrados.Text = "Usuarios registrados: " + listaAlumnos.Count;

        }

        private void buttonAcceso_Click(object sender, EventArgs e)
        {
            String usr = textBoxUsr.Text;
            String pass = textBoxPass.Text;
            if (!alumnoExiste(usr))
            {
                Registro registro = new Registro();
                DialogResult r = registro.ShowDialog();

                if(r == DialogResult.OK)
                {
                    Alumno nuevoAlumno = registro.alumno;

                    
                        listaAlumnos.Add(nuevoAlumno);

                        MessageBox.Show("¡Alumno agregado a la lista principal con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        labelUsuariosRegistrados.Text = "Usuarios registrados: " + listaAlumnos.Count;
                    
                    return;
                    
                }
            }
            Alumno a = usrYPassCorrectas(usr, pass);
            if (a != null)
            {
                DatosUsuario datos = new DatosUsuario(a);
                datos.Show();
            }
            
        }

        private Boolean alumnoExiste(String usr)
        {
            foreach(Alumno u in listaAlumnos)
            {
                if (u.usr == usr)
                {
                    return true;
                }
            }
            return false;
        }

        private Alumno usrYPassCorrectas(String nombre, String pass)
        {
            foreach (Alumno u in listaAlumnos)
            {
                if (u.nombre == nombre && u.pass == pass)
                {
                    return u;
                }
            }
            return null;
        }

        private void Acceso_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Seguro que quiere cerrar la aplicación?", "Salir", MessageBoxButtons.YesNo);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
