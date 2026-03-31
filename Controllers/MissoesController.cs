using Microsoft.AspNetCore.Mvc;
using SpiderNetApi.Models;

namespace SpiderNetApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MissoesController : ControllerBase
    {
        // Simulação de banco
        private static List<MissaoAranha> missoes = new List<MissaoAranha>();

        // GET
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(missoes);
        }

        // POST
        [HttpPost]
        public IActionResult Post([FromBody] MissaoAranha novaMissao)
        {
            if (novaMissao.NivelPerigo < 1 || novaMissao.NivelPerigo > 10)
            {
                return BadRequest("Nivel de perigo deve ser entre 1 e 10");
            }

            missoes.Add(novaMissao);
            return Ok(novaMissao);
        }
    }
}