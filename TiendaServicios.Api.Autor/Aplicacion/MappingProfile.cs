using AutoMapper;
using TiendaServicios.Api.Autor.Modelo;

namespace TiendaServicios.Api.Autor.Aplicacion
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            //La clase AutorLibro va a convertirse en una clase AutorDto
            CreateMap<AutorLibro, AutorDto>();
        }
    }
}
