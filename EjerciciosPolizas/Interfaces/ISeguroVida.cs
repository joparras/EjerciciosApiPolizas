using EjerciciosPolizas.Models;

namespace EjerciciosPolizas.Interfaces
{
    public interface ISeguroVida
    {
        RespuestaCotizacion ObtenerCotizacion(SolicitudCotizacionVida solicitud);
    }
}
