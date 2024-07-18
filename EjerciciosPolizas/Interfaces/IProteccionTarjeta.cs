using EjerciciosPolizas.Models;

namespace EjerciciosPolizas.Interfaces
{
    public interface IProteccionTarjeta
    {
        RespuestaCotizacion ObtenerCotizacion(SolicitudCotizacionProteccionTarjeta solicitud);
    }
}


