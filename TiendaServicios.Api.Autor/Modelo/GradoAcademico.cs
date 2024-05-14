namespace TiendaServicios.Api.Autor.Modelo
{
    //Mapear la tabla GradoAcademico
    public class GradoAcademico
    {
        public int GradoAcademicoId { get; set; }
        public string Nombre { get; set; }
        public string CentroAcademico { get; set; }
        public DateTime? FechaGrado { get; set; }
        public int AutorLibroId { get; set; }
        public AutorLibro AutorLibro { get; set; }
        //Clave única para el grado académico en cualquier contexto
        public string GradoAcademicoLibroGuid { get; set; }
    }
}
