using Microsoft.AspNetCore.Mvc;
using ProjetoRedeHoteis.Lib.Models;
using ProjetoRedeHoteis.Web.DTOs;

namespace ProjetoRedeHoteis.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstadiaController : ControllerBase
    {
        public static List<Estadia> Estadias { get; set; } = new List<Estadia>();

        [HttpPost("Adicionar Estadia")]
        public IActionResult AddEstadia(EstadiaDTO estadia)
        {
            var estadiaNova = new Estadia(estadia.Id, estadia.DataCadastro, estadia.DataUltimaAtualizacao, estadia.DataEntrada,
                                          estadia.DataSaida, estadia.ValorTotal, estadia.IdResponsavel, estadia.IdQuarto);
            Estadias.Add(estadiaNova);
            return Ok(Estadias);
        }
        [HttpGet("Buscar Estadias")]
        public IActionResult GetEstadias()
        {
            return Ok(Estadias);
        }
        [HttpGet("Buscar CategoriaQuarto por Id")]
        public IActionResult GetEstadiaPorId(int idEstadia)
        {
            return Ok(Estadias.Find(x => x.GetId() == idEstadia));
        }
        [HttpDelete("Deletar Estadia por Id")]
        public IActionResult DeleteEstadiaPorId(int idEstadia)
        {
            Estadias.RemoveAll(x => x.GetId() == idEstadia);
            return Ok(Estadias);
        }
    }
}