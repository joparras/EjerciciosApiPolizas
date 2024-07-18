using EjerciciosPolizas.Enums;

namespace EjerciciosPolizas.Models
{
    public class SolicitudCotizacionVehicular
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public decimal ValorEstimado { get; set; }
        public UsoVehiculo Uso {  get; set; }
        
    }
}
