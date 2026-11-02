using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionAlumnos
{
    public partial class ConsultarAlumnos : Form
    {
        private List<Alumno> listaAlumnos;
        private String alumnosFiltrados;

        string curso = "";
        string grupo = "";

        public ConsultarAlumnos(List<Alumno> alumnos)
        {
            InitializeComponent();
            listaAlumnos = alumnos;
        }

        private void consultarAlumnos(object sender, EventArgs e)
        {
            string[] partes = textBoxCursoYGrupo.Text.Split(' ');
            if (partes.Length > 0){curso = partes[0];}
            if (partes.Length > 1){grupo = partes[1];}

            alumnosFiltrados = "";
            foreach (var item in listaAlumnos)
            {
                if(item.Curso==curso && item.Grupo==grupo) {
                    alumnosFiltrados += item.ObtenerResumen() + Environment.NewLine;
                }
            }
            labelAlumnos.Text = alumnosFiltrados;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
