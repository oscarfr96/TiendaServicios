namespace TiendaServicios.Api.CarritoCompra.Modelo
{
    public class CarritoSesion
    {
        public int CarritoSesionId { get; set; }
        public DateTime? FechaCreacion { get; set; }
        //Un CarritoSesion tendrá muchos CarritoSesionDetalle
        public ICollection<CarritoSesionDetalle> ListaDetalle { get; set; }
    }
}
