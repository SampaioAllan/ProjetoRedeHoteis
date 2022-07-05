using Microsoft.AspNetCore.Mvc;
using ProjetoRedeHoteis.Lib.Data.Repositorios.Interfaces;
using ProjetoRedeHoteis.Lib.Models;
using ProjetoRedeHoteis.Web.DTOs;

namespace ProjetoRedeHoteis.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServicoController : ControllerBase
    {
        private readonly IServicoRepositorio _repositorio;
        public ServicoController(IServicoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpPost("Adicionar Servico")]
        public IActionResult AddServico(ServicoDTO servico)
        {
            var servicoNovo = new Servico(servico.Id, servico.DataCadastroTabela, servico.DataUltimaAtualizacaoTabela, servico.Nome);
            _repositorio.Adicionar(servicoNovo);
            return Ok();
        }
        [HttpGet("Buscar Servicos")]
        public IActionResult GetServicos()
        {
            return Ok(_repositorio.BuscarTodos());
        }
        [HttpGet("Buscar Servico por Id")]
        public IActionResult GetServicoPorId(int idServico)
        {
            return Ok(_repositorio.BuscarPorId(idServico));
        }
        [HttpDelete("Deletar Servico por Id")]
        public IActionResult DeleteServicoPorId(int idServico)
        {
            _repositorio.DeletarItemDesejado(idServico);
            return Ok();
        }
    }
}