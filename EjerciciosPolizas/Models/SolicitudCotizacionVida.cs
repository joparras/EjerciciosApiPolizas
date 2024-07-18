
using EjerciciosPolizas.Enums;

namespace EjerciciosPolizas.Models
{
    public class SolicitudCotizacionVida
    {
        public int Edad {  get; set; }
        public EstadoSalud EstadoSalud { get; set; }
        public decimal MontoAsegurado { get; set; }
    }
}
