using EjerciciosPolizas.Enums;
using EjerciciosPolizas.Interfaces;
using EjerciciosPolizas.Models;

namespace EjerciciosPolizas.Servicios
{
    public class ServicioProteccionTarjeta : IProteccionTarjeta
    {
        public RespuestaCotizacion ObtenerCotizacion(SolicitudCotizacionProteccionTarjeta solicitud)
        {
            decimal factorRiesgo = ObtenerFactorRiesgo(solicitud.TipoTarjeta);
            decimal cotizacionTarjeta = CalcularCotizacionTarjeta(solicitud.LimiteCredito, factorRiesgo);
            
            return new RespuestaCotizacion
            {
                Cotizacion = cotizacionTarjeta,
                Terminos = "Términos y Condiciones de la Protección de Tarjeta de Crédito"
            };
        }
        private decimal ObtenerFactorRiesgo(TipoTarjeta tipoTarjeta)
        {
            return tipoTarjeta switch
            {
                TipoTarjeta.Estandar => 1.1m,
                TipoTarjeta.Premium => 1.2m,
                _ => 1.0m,
            };
        }
        private decimal CalcularCotizacionTarjeta(decimal limiteCredito, decimal factorRiesgo)
        {
            return (limiteCredito / 12) * factorRiesgo;
        }
    }
}
