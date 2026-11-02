namespace GestionAlumnos
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public string Dni { get; set; }
        public string Curso { get; set; }
        public string Grupo { get; set; }
        public string ObtenerResumen()
        {
            return $"{Nombre} - {Curso} ({Grupo}) [DNI: {Dni}]";
        }
    }
}
