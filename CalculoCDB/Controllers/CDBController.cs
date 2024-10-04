using CalculoCDB.Models;
using CalculoCDB.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalculoCDB.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CDBController : ControllerBase
    {
        private readonly CDBService _cdbService;

        public CDBController()
        {
            _cdbService = new CDBService();
        }

        [HttpPost]
        public IActionResult Calcular([FromBody] ParametrosCDB investimento)
        {
            if (investimento.ValorInicial <= 0 || investimento.Meses <= 0)
            {
                return BadRequest("Os valores devem ser positivos.");
            }

            var resultado = _cdbService.CalcularCDB(investimento);
            return Ok(new
            {
                Bruto = resultado.Bruto,
                Liquido = resultado.Liquido
            });
        }
    }
}
