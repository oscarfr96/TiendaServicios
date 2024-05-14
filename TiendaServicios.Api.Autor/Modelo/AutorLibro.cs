namespace TiendaServicios.Api.Autor.Modelo
{
    //Mapear la tabla AutorLibro
    public class AutorLibro
    {
        public int AutorLibroId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public ICollection<GradoAcademico> ListaGradoAcademico { get; set; }
        //Clave única para mi autor en cualquier contexto
        public string AutorLibroGuid { get; set; }
    }
}
