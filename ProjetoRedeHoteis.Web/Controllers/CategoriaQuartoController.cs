using Microsoft.AspNetCore.Mvc;
using ProjetoRedeHoteis.Lib.Models;
using ProjetoRedeHoteis.Web.DTOs;

namespace ProjetoRedeHoteis.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaQuartoController : ControllerBase
    {
        public static List<CategoriaQuarto> CategoriasQuartos { get; set; } = new List<CategoriaQuarto>();

        [HttpPost("Adicionar CategoriaQuarto")]
        public IActionResult AddCategoriaQuarto(CategoriaQuartoDTO categoriaQuarto)
        {
            var categoriaQuartoNova = new CategoriaQuarto(categoriaQuarto.Id, categoriaQuarto.DataCadastro, categoriaQuarto.DataUltimaAtualizacao,
                                                          categoriaQuarto.Nome, categoriaQuarto.Descricao, categoriaQuarto.OcupacaoMaxima,
                                                          categoriaQuarto.CamaCasal, categoriaQuarto.CamaSolteiro, categoriaQuarto.Valor);
            CategoriasQuartos.Add(categoriaQuartoNova);
            return Ok(CategoriasQuartos);
        }
        [HttpGet("Buscar CategoriasQuartos")]
        public IActionResult GetCategoriasQuartos()
        {
            return Ok(CategoriasQuartos);
        }
        [HttpGet("Buscar CategoriaQuarto por Id")]
        public IActionResult GetCategoriaQuartoPorId(int idCategoriaQuarto)
        {
            return Ok(CategoriasQuartos.Find(x => x.GetId() == idCategoriaQuarto));
        }
        [HttpDelete("Deletar CategoriaQuarto por Id")]
        public IActionResult DeleteCategoriaQuartoPorId(int idCategoriaQuarto)
        {
            CategoriasQuartos.RemoveAll(x => x.GetId() == idCategoriaQuarto);
            return Ok(CategoriasQuartos);
        }
    }
}