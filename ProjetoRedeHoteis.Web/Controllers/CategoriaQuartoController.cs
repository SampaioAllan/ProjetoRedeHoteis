using Microsoft.AspNetCore.Mvc;
using ProjetoRedeHoteis.Lib.Data.Repositorios.Interfaces;
using ProjetoRedeHoteis.Lib.Models;
using ProjetoRedeHoteis.Web.DTOs;

namespace ProjetoRedeHoteis.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaQuartoController : ControllerBase
    {
        private readonly ICategoriaQuartoRepositorio _repositorio;
        public CategoriaQuartoController(ICategoriaQuartoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpPost("Adicionar CategoriaQuarto")]
        public IActionResult AddCategoriaQuarto(CategoriaQuartoDTO categoriaQuarto)
        {
            var categoriaQuartoNova = new CategoriaQuarto(categoriaQuarto.Id, categoriaQuarto.DataCadastroTabela, categoriaQuarto.DataUltimaAtualizacaoTabela,
                                                          categoriaQuarto.Nome, categoriaQuarto.Descricao, categoriaQuarto.OcupacaoMaxima,
                                                          categoriaQuarto.CamaCasal, categoriaQuarto.CamaSolteiro, categoriaQuarto.Valor);
            _repositorio.Adicionar(categoriaQuartoNova);
            return Ok();
        }
        [HttpGet("Buscar CategoriasQuartos")]
        public IActionResult GetCategoriasQuartos()
        {
            return Ok(_repositorio.BuscarTodos());
        }
        [HttpGet("Buscar CategoriaQuarto por Id")]
        public IActionResult GetCategoriaQuartoPorId(int idCategoriaQuarto)
        {
            return Ok(_repositorio.BuscarPorId(idCategoriaQuarto));
        }
        [HttpDelete("Deletar CategoriaQuarto por Id")]
        public IActionResult DeleteCategoriaQuartoPorId(int idCategoriaQuarto)
        {
            _repositorio.DeletarItemDesejado(idCategoriaQuarto);
            return Ok();
        }
    }
}