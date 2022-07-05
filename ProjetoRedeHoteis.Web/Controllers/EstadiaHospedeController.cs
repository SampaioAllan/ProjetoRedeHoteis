using Microsoft.AspNetCore.Mvc;
using ProjetoRedeHoteis.Lib.Data.Repositorios;
using ProjetoRedeHoteis.Lib.Models;
using ProjetoRedeHoteis.Web.DTOs;

namespace ProjetoRedeHoteis.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstadiaHospedeController : ControllerBase
    {
        private readonly EstadiaHospedeRepositorio _repositorio;
        public EstadiaHospedeController(EstadiaHospedeRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpPost("Adicionar EstadiaHospede")]
        public IActionResult AddEstadiaHospede(EstadiaHospedeDTO estadiaHospede)
        {
            var estadiaHospedeNova = new EstadiaHospede(estadiaHospede.Id, estadiaHospede.DataCadastroTabela, estadiaHospede.DataUltimaAtualizacaoTabela,
                                                        estadiaHospede.IdEstadia, estadiaHospede.IdHospede);
            _repositorio.Adicionar(estadiaHospedeNova);
            return Ok();
        }
        [HttpGet("Buscar EstadiasHospedes")]
        public IActionResult GetEstadiasHospedes()
        {
            return Ok(_repositorio.BuscarTodos());
        }
        [HttpGet("Buscar EstadiaHospede por Id")]
        public IActionResult GetEstadiaHospedePorId(int idEstadiaHospede)
        {
            return Ok(_repositorio.BuscarPorId(idEstadiaHospede));
        }
        [HttpDelete("Deletar EstadiaHospede por Id")]
        public IActionResult DeleteEstadiaHospedePorId(int idEstadiaHospede)
        {
            _repositorio.DeletarItemDesejado(idEstadiaHospede);
            return Ok();
        }
    }
}