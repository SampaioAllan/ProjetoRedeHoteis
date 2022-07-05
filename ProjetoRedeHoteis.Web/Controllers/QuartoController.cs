using Microsoft.AspNetCore.Mvc;
using ProjetoRedeHoteis.Lib.Data.Repositorios;
using ProjetoRedeHoteis.Lib.Models;
using ProjetoRedeHoteis.Web.DTOs;

namespace ProjetoRedeHoteis.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuartoController : ControllerBase
    {
        private readonly QuartoRepositorio _repositorio;
        public QuartoController(QuartoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpPost("Adicionar Quarto")]
        public IActionResult AddQuarto(QuartoDTO quarto)
        {
            var quartoNovo = new Quarto(quarto.Id, quarto.DataCadastroTabela, quarto.DataUltimaAtualizacaoTabela, quarto.Numero, quarto.Andar,
                                        quarto.IdCategoria, quarto.IdHotel);
            _repositorio.Adicionar(quartoNovo);
            return Ok();
        }
        [HttpGet("Buscar Quartos")]
        public IActionResult GetQuartos()
        {
            return Ok(_repositorio.BuscarTodos());
        }
        [HttpGet("Buscar Quarto por Id")]
        public IActionResult GetQuartoPorId(int idQuarto)
        {
            return Ok(_repositorio.BuscarPorId(idQuarto));
        }
        [HttpDelete("Deletar CategoriaQuarto por Id")]
        public IActionResult DeleteQuartoPorId(int idQuarto)
        {
            _repositorio.DeletarItemDesejado(idQuarto);
            return Ok();
        }
    }
}