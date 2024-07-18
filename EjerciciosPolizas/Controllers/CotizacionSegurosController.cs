
using EjerciciosPolizas.Interfaces;
using EjerciciosPolizas.Models;
using Microsoft.AspNetCore.Mvc;

namespace EjerciciosPolizas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CotizacionSegurosController : ControllerBase
    {
        private readonly ISeguroVida _servicioSeguroVida;
        private readonly ISeguroVehicular _servicioSeguroVehicular;
        private readonly IProteccionTarjeta _servicioProteccionTarjeta;

        public CotizacionSegurosController(ISeguroVida servicioSeguroVida, ISeguroVehicular servicioSeguroVehicular, IProteccionTarjeta servicioProteccionTarjeta)
        {
            _servicioSeguroVida = servicioSeguroVida;
            _servicioSeguroVehicular = servicioSeguroVehicular;
            _servicioProteccionTarjeta = servicioProteccionTarjeta;
        }

        [HttpPost("vida")]
        public ActionResult<RespuestaCotizacion> ObtenerCotizacionVida([FromBody] SolicitudCotizacionVida solicitud)
        {
            return Ok(_servicioSeguroVida.ObtenerCotizacion(solicitud));
        }

        [HttpPost("vehicular")]
        public ActionResult<RespuestaCotizacion> ObtenerCotizacionVehicular([FromBody] SolicitudCotizacionVehicular solicitud)
        {
            return Ok(_servicioSeguroVehicular.ObtenerCotizacion(solicitud));
        }

        [HttpPost("tarjeta")]
        public ActionResult<RespuestaCotizacion> ObtenerCotizacionProteccionTarjeta([FromBody] SolicitudCotizacionProteccionTarjeta solicitud)
        {
            return Ok(_servicioProteccionTarjeta.ObtenerCotizacion(solicitud));
        }
    }
}
