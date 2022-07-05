using Microsoft.AspNetCore.Mvc;
using ProjetoRedeHoteis.Lib.Data.Repositorios.Interfaces;
using ProjetoRedeHoteis.Lib.Models;
using ProjetoRedeHoteis.Web.DTOs;

namespace ProjetoRedeHoteis.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HospedeController : ControllerBase
    {
        private readonly IHospedeRepositorio _repositorio;
        public HospedeController(IHospedeRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpPost("Adicionar Hospede")]
        public IActionResult AddHospede(HospedeDTO hospede)
        {
            var hospedeNovo = new Hospede(hospede.Id, hospede.DataCadastroTabela, hospede.DataUltimaAtualizacaoTabela, hospede.Nome, hospede.Telefone,
                                          hospede.Cpf, hospede.Email, hospede.DataNascimento);
            _repositorio.Adicionar(hospedeNovo);
            return Ok();
        }
        [HttpGet("Buscar Hospedes")]
        public IActionResult GetHospedes()
        {
            return Ok(_repositorio.BuscarTodos());
        }
        [HttpGet("Buscar Hospede por Id")]
        public IActionResult GetHospedePorId(int idHospede)
        {
            return Ok(_repositorio.BuscarPorId(idHospede));
        }
        [HttpDelete("Deletar Hospede por Id")]
        public IActionResult DeleteHospedePorId(int idHospede)
        {
            _repositorio.DeletarItemDesejado(idHospede);
            return Ok();
        }
    }
}