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
            listaAlumnos.Add(new Alumno { Nombre = "Juan Pérez", Dni = "12345678A", Curso = "1", Grupo = "A" });
            listaAlumnos.Add(new Alumno { Nombre = "asdfasdf", Dni = "12345678A", Curso = "2", Grupo = "b" });
        }

        private void matricularAlumnoButton_Click(object sender, EventArgs e)
        {
            // 1. Instanciar el formulario secundario
            using (MatricularAlumno formCreacion = new MatricularAlumno())
            {
                // 2. Abrirlo como ventana modal (bloquea la principal hasta que se cierre)
                DialogResult resultado = formCreacion.ShowDialog();

                // 3. Comprobar si el usuario guardó los datos (DialogResult.OK)
                if (resultado == DialogResult.OK)
                {
                    // 4. Obtener el alumno desde la propiedad del formulario secundario
                    Alumno nuevoAlumno = formCreacion.alumnoNuevo;

                    if (nuevoAlumno != null)
                    {
                        // 5. Añadirlo a la lista que vive en el formulario principal
                        listaAlumnos.Add(nuevoAlumno);

                        MessageBox.Show("¡Alumno agregado a la lista principal con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void salirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consultarAlumnosButton_Click(object sender, EventArgs e)
        {
            ConsultarAlumnos consultarAlumnos = new ConsultarAlumnos(listaAlumnos);
            consultarAlumnos.Show();
        }
    }
}
