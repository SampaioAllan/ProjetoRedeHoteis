using Microsoft.AspNetCore.Mvc;
using ProjetoRedeHoteis.Lib.Models;
using ProjetoRedeHoteis.Web.DTOs;

namespace ProjetoRedeHoteis.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HospedeController : ControllerBase
    {
        public static List<Hospede> Hospedes { get; set; } = new List<Hospede>();

        [HttpPost("Adicionar Hospede")]
        public IActionResult AddHospede(HospedeDTO hospede)
        {
            var hospedeNovo = new Hospede(hospede.Id, hospede.DataCadastro, hospede.DataUltimaAtualizacao, hospede.Nome, hospede.Telefone,
                                          hospede.Cpf, hospede.Email, hospede.DataNascimento);
            Hospedes.Add(hospedeNovo);
            return Ok(Hospedes);
        }
        [HttpGet("Buscar Hospedes")]
        public IActionResult GetHospedes()
        {
            return Ok(Hospedes);
        }
        [HttpGet("Buscar Hospede por Id")]
        public IActionResult GetHospedePorId(int idHospede)
        {
            return Ok(Hospedes.Find(x => x.GetId() == idHospede));
        }
        [HttpDelete("Deletar Hospede por Id")]
        public IActionResult DeleteHospedePorId(int idHospede)
        {
            Hospedes.RemoveAll(x => x.GetId() == idHospede);
            return Ok(Hospedes);
        }
    }
}