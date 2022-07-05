using Microsoft.AspNetCore.Mvc;
using ProjetoRedeHoteis.Lib.Data.Repositorios;
using ProjetoRedeHoteis.Lib.Models;
using ProjetoRedeHoteis.Web.DTOs;

namespace ProjetoRedeHoteis.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstadiaController : ControllerBase
    {
        private readonly EstadiaRepositorio _repositorio;
        public EstadiaController(EstadiaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpPost("Adicionar Estadia")]
        public IActionResult AddEstadia(EstadiaDTO estadia)
        {
            var estadiaNova = new Estadia(estadia.Id, estadia.DataCadastroTabela, estadia.DataUltimaAtualizacaoTabela, estadia.DataEntrada,
                                          estadia.DataSaida, estadia.ValorTotal, estadia.IdResponsavel, estadia.IdQuarto);
            _repositorio.Adicionar(estadiaNova);
            return Ok();
        }
        [HttpGet("Buscar Estadias")]
        public IActionResult GetEstadias()
        {
            return Ok(_repositorio.BuscarTodos());
        }
        [HttpGet("Buscar CategoriaQuarto por Id")]
        public IActionResult GetEstadiaPorId(int idEstadia)
        {
            return Ok(_repositorio.BuscarPorId(idEstadia));
        }
        [HttpDelete("Deletar Estadia por Id")]
        public IActionResult DeleteEstadiaPorId(int idEstadia)
        {
            _repositorio.DeletarItemDesejado(idEstadia);
            return Ok();
        }
    }
}