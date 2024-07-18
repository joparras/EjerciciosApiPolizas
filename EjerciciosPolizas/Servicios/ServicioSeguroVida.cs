using EjerciciosPolizas.Enums;
using EjerciciosPolizas.Interfaces;
using EjerciciosPolizas.Models;

namespace EjerciciosPolizas.Servicios
{
    public class ServicioSeguroVida : ISeguroVida
    {
        private const int EsperanzaVida = 80;

        public RespuestaCotizacion ObtenerCotizacion(SolicitudCotizacionVida solicitud)
        {
            decimal factorRiesgo = ObtenerFactorRiesgo(solicitud.EstadoSalud);
            decimal cotizacionVida = CalcularCotizacionVida(solicitud.MontoAsegurado, solicitud.Edad,factorRiesgo);


            return new RespuestaCotizacion
            {
                Cotizacion = cotizacionVida,
                Terminos = "Terminos y Condiciones del Seguro Vida"
             
            };
        }
        private decimal ObtenerFactorRiesgo(EstadoSalud estadoSalud)
        {
            return estadoSalud switch
            {
                EstadoSalud.Regular => 1.2m,
                EstadoSalud.Pobre => 1.5m,
                EstadoSalud.Malo => 1.0m,
            };
        }
        private decimal CalcularCotizacionVida(decimal montoAsegurado, int edad, decimal factorRiesgo)
        {
            return (montoAsegurado/(EsperanzaVida - edad)) * factorRiesgo;
        }

  
    }
}
