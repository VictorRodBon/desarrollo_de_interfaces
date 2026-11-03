using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAlumnos
{
    public partial class Form1 : Form
    {
        private List<Alumno> listaAlumnos = new List<Alumno>();
        
        
        public Form1()
        {
            InitializeComponent();
            listaAlumnos.Add(new Alumno { Nombre = "Luis Rodriguez", Dni = "12345678A", Curso = "1", Grupo = "A" });
            listaAlumnos.Add(new Alumno { Nombre = "Juan Pérez", Dni = "45678912B", Curso = "2", Grupo = "A" });
            listaAlumnos.Add(new Alumno { Nombre = "Adrian Lopez", Dni = "11111111A", Curso = "1", Grupo = "B" });
            listaAlumnos.Add(new Alumno { Nombre = "Pepito Grillo", Dni = "12345678A", Curso = "2", Grupo = "B" });
        }

        private void matricularAlumnoButton_Click(object sender, EventArgs e)
        {
            MatricularAlumno formCreacion = new MatricularAlumno();
            DialogResult resultado = formCreacion.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                Alumno nuevoAlumno = formCreacion.alumnoNuevo;

                if (nuevoAlumno != null)
                {
                    listaAlumnos.Add(nuevoAlumno);

                    MessageBox.Show("¡Alumno agregado a la lista principal con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void salirButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere cerrrar?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes
                ) {
                this.Close();

            }
        }

        private void consultarAlumnosButton_Click(object sender, EventArgs e)
        {
            ConsultarAlumnos consultarAlumnos = new ConsultarAlumnos(listaAlumnos);
            consultarAlumnos.Show();
        }
    }
}
