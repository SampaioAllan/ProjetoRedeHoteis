using Microsoft.AspNetCore.Mvc;
using ProjetoRedeHoteis.Lib.Models;
using ProjetoRedeHoteis.Web.DTOs;

namespace ProjetoRedeHoteis.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServicoController : ControllerBase
    {
        public static List<Servico> Servicos { get; set; } = new List<Servico>();

        [HttpPost("Adicionar Servico")]
        public IActionResult AddServico(ServicoDTO servico)
        {
            var servicoNovo = new Servico(servico.Id, servico.DataCadastro, servico.DataUltimaAtualizacao, servico.Nome);
            Servicos.Add(servicoNovo);
            return Ok(Servicos);
        }
        [HttpGet("Buscar Servicos")]
        public IActionResult GetServicos()
        {
            return Ok(Servicos);
        }
        [HttpGet("Buscar Servico por Id")]
        public IActionResult GetServicoPorId(int idServico)
        {
            return Ok(Servicos.Find(x => x.GetId() == idServico));
        }
        [HttpDelete("Deletar Servico por Id")]
        public IActionResult DeleteServicoPorId(int idServico)
        {
            Servicos.RemoveAll(x => x.GetId() == idServico);
            return Ok(Servicos);
        }
    }
}