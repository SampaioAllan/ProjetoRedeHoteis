using Microsoft.AspNetCore.Mvc;
using ProjetoRedeHoteis.Lib.Data.Repositorios.Interfaces;
using ProjetoRedeHoteis.Lib.Models;
using ProjetoRedeHoteis.Web.DTOs;

namespace ProjetoRedeHoteis.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServicoHotelController : ControllerBase
    {
        private readonly IServicoHotelRepositorio _repositorio;
        public ServicoHotelController(IServicoHotelRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpPost("Adicionar ServicosHoteis")]
        public IActionResult AddCategoriaQuarto(ServicoHotelDTO servicoHotel)
        {
            var servicosHoteisNovo = new ServicoHotel(servicoHotel.Id, servicoHotel.DataCadastroTabela, servicoHotel.DataUltimaAtualizacaoTabela,
                                                      servicoHotel.IdServico, servicoHotel.IdHotel);
            _repositorio.Adicionar(servicosHoteisNovo);
            return Ok();
        }
        [HttpGet("Buscar ServicosHoteis")]
        public IActionResult GetServicosHoteis()
        {
            return Ok(_repositorio.BuscarTodos());
        }
        [HttpGet("Buscar ServicosHoteis por Id")]
        public IActionResult GetServicosHoteisPorId(int idServicosHoteis)
        {
            return Ok(_repositorio.BuscarPorId(idServicosHoteis));
        }
        [HttpDelete("Deletar ServicosHoteis por Id")]
        public IActionResult DeleteServicosHoteisPorId(int idServicosHoteis)
        {
            _repositorio.DeletarItemDesejado(idServicosHoteis);
            return Ok();
        }
    }
}