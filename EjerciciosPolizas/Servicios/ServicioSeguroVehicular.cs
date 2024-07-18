using EjerciciosPolizas.Enums;
using EjerciciosPolizas.Interfaces;
using EjerciciosPolizas.Models;

namespace EjerciciosPolizas.Servicios
{
    public class ServicioSeguroVehicular : ISeguroVehicular
    {
        public RespuestaCotizacion ObtenerCotizacion(SolicitudCotizacionVehicular solicitud)
        {
            int edadVehiculo = DateTime.Now.Year - solicitud.Anio;
            decimal factorRiesgo = ObtenerFactorRiesgo(solicitud.Uso);
            decimal cotizacionVehicular = CalcularCotizacionVehicular(solicitud.ValorEstimado, edadVehiculo, factorRiesgo);

            return new RespuestaCotizacion
            {
                Cotizacion = cotizacionVehicular,
                Terminos = "Términos y Condiciones del Seguro Vehicular"
            };
        }
        private decimal ObtenerFactorRiesgo(UsoVehiculo usoVehiculo)
        {
            return usoVehiculo switch
            {
                UsoVehiculo.Regular => 1.1m,
                UsoVehiculo.Intensivo => 1.3m,
                _ => 1.0m,
            };
        }
        private decimal CalcularCotizacionVehicular(decimal valorVehiculo, int edadVehiculo, decimal factorRiesgo)
        {
            return (valorVehiculo / edadVehiculo) * factorRiesgo;
        }

    }
}
