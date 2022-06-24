using Microsoft.AspNetCore.Mvc;
using ProjetoRedeHoteis.Lib.Models;
using ProjetoRedeHoteis.Web.DTOs;

namespace ProjetoRedeHoteis.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServicoHotelController : ControllerBase
    {
        public static List<ServicoHotel> ServicosHoteis { get; set; } = new List<ServicoHotel>();

        [HttpPost("Adicionar ServicosHoteis")]
        public IActionResult AddCategoriaQuarto(ServicoHotelDTO servicoHotel)
        {
            var servicosHoteisNovo = new ServicoHotel(servicoHotel.Id, servicoHotel.DataCadastro, servicoHotel.DataUltimaAtualizacao,
                                                      servicoHotel.IdServico, servicoHotel.IdHotel);
            ServicosHoteis.Add(servicosHoteisNovo);
            return Ok(ServicosHoteis);
        }
        [HttpGet("Buscar ServicosHoteis")]
        public IActionResult GetServicosHoteis()
        {
            return Ok(ServicosHoteis);
        }
        [HttpGet("Buscar ServicosHoteis por Id")]
        public IActionResult GetServicosHoteisPorId(int idServicosHoteis)
        {
            return Ok(ServicosHoteis.Find(x => x.GetId() == idServicosHoteis));
        }
        [HttpDelete("Deletar ServicosHoteis por Id")]
        public IActionResult DeleteServicosHoteisPorId(int idServicosHoteis)
        {
            ServicosHoteis.RemoveAll(x => x.GetId() == idServicosHoteis);
            return Ok(ServicosHoteis);
        }
    }
}