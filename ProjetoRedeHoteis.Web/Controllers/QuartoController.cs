using Microsoft.AspNetCore.Mvc;
using ProjetoRedeHoteis.Lib.Models;
using ProjetoRedeHoteis.Web.DTOs;

namespace ProjetoRedeHoteis.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuartoController : ControllerBase
    {
        public static List<Quarto> Quartos { get; set; } = new List<Quarto>();

        [HttpPost("Adicionar Quarto")]
        public IActionResult AddQuarto(QuartoDTO quarto)
        {
            var quartoNovo = new Quarto(quarto.Id, quarto.DataCadastro, quarto.DataUltimaAtualizacao, quarto.Numero, quarto.Andar,
                                        quarto.IdCategoria, quarto.IdHotel);
            Quartos.Add(quartoNovo);
            return Ok(Quartos);
        }
        [HttpGet("Buscar Quartos")]
        public IActionResult GetQuartos()
        {
            return Ok(Quartos);
        }
        [HttpGet("Buscar Quarto por Id")]
        public IActionResult GetQuartoPorId(int idQuarto)
        {
            return Ok(Quartos.Find(x => x.GetId() == idQuarto));
        }
        [HttpDelete("Deletar CategoriaQuarto por Id")]
        public IActionResult DeleteQuartoPorId(int idQuarto)
        {
            Quartos.RemoveAll(x => x.GetId() == idQuarto);
            return Ok(Quartos);
        }
    }
}