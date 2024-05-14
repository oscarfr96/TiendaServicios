using TiendaServicios.Api.Autor.Modelo;

namespace TiendaServicios.Api.Autor.Aplicacion
{
    //Modelar los datos que se van a enviar a cliente (sólo lo que queremos) en consultas, sólo consultas!!
    public class AutorDto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        //Clave única para mi autor en cualquier contexto
        public string AutorLibroGuid { get; set; }
    }
}
