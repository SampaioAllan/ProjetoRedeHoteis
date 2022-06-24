using Microsoft.AspNetCore.Mvc;
using ProjetoRedeHoteis.Lib.Models;
using ProjetoRedeHoteis.Web.DTOs;

namespace ProjetoRedeHoteis.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstadiaHospedeController : ControllerBase
    {
        public static List<EstadiaHospede> EstadiasHospedes { get; set; } = new List<EstadiaHospede>();

        [HttpPost("Adicionar EstadiaHospede")]
        public IActionResult AddEstadiaHospede(EstadiaHospedeDTO estadiaHospede)
        {
            var estadiaHospedeNova = new EstadiaHospede(estadiaHospede.Id, estadiaHospede.DataCadastro, estadiaHospede.DataUltimaAtualizacao,
                                                        estadiaHospede.IdEstadia, estadiaHospede.IdHospede);
            EstadiasHospedes.Add(estadiaHospedeNova);
            return Ok(EstadiasHospedes);
        }
        [HttpGet("Buscar EstadiasHospedes")]
        public IActionResult GetEstadiasHospedes()
        {
            return Ok(EstadiasHospedes);
        }
        [HttpGet("Buscar EstadiaHospede por Id")]
        public IActionResult GetEstadiaHospedePorId(int IdEstadiaHospede)
        {
            return Ok(EstadiasHospedes.Find(x => x.GetId() == IdEstadiaHospede));
        }
        [HttpDelete("Deletar EstadiaHospede por Id")]
        public IActionResult DeleteEstadiaHospedePorId(int idEstadiaHospede)
        {
            EstadiasHospedes.RemoveAll(x => x.GetId() == idEstadiaHospede);
            return Ok(EstadiasHospedes);
        }
    }
}