using System.Runtime.Serialization;

namespace EjerciciosPolizas.Enums
{
    public enum EstadoSalud
    {
        [EnumMember(Value = "Regular")]
        Regular =0,
        [EnumMember(Value = "Pobre")]
        Pobre =1,
        [EnumMember(Value = "Malo")]
        Malo =2
    }
    public enum UsoVehiculo
    {
        [EnumMember(Value = "Regular")]
        Regular=0,
        [EnumMember(Value = "Intensivo")]
        Intensivo =1
    }
    public enum TipoTarjeta
    {
        [EnumMember(Value = "Estandar")]
        Estandar =0,
        [EnumMember(Value = "Premium")]
        Premium =1
    }
}
