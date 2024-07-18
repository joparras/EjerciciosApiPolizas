using EjerciciosPolizas.Models;

namespace EjerciciosPolizas.Interfaces
{
    public interface ISeguroVehicular
    {
        RespuestaCotizacion ObtenerCotizacion(SolicitudCotizacionVehicular solicitud);
    }
}
