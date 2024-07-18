using EjerciciosPolizas.Enums;

namespace EjerciciosPolizas.Models
{
    public class SolicitudCotizacionProteccionTarjeta
    {
        public decimal LimiteCredito { get; set; }
        public TipoTarjeta TipoTarjeta { get; set; }
    }
}
