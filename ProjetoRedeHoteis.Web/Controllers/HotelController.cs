using Microsoft.AspNetCore.Mvc;
using ProjetoRedeHoteis.Lib.Models;
using ProjetoRedeHoteis.Web.DTOs;

namespace ProjetoRedeHoteis.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HotelController : ControllerBase
    {
        public static List<Hotel> Hoteis;

        [HttpPost("Adicionar CategoriaQuarto")]
        public IActionResult AddHotel(HotelDTO hotel)
        {
            var hotelNovo = new Hotel(hotel.Id, hotel.DataCadastro, hotel.DataUltimaAtualizacao, hotel.Nome, hotel.Endereco,
                                      hotel.Cep, hotel.Descricao, hotel.Telefone, hotel.Email, hotel.HorarioCheckIn,
                                      hotel.HorarioCheckOut);
            Hoteis.Add(hotelNovo);
            return Ok(Hoteis);
        }
        [HttpGet("Buscar Hoteis")]
        public IActionResult GetHoteis()
        {
            return Ok(Hoteis);
        }
        [HttpGet("Buscar Hotel por Id")]
        public IActionResult GetHotelPorId(int idHotel)
        {
            return Ok(Hoteis.Find(x => x.GetId() == idHotel));
        }
        [HttpDelete("Deletar Hotel por Id")]
        public IActionResult DeleteHotelPorId(int idHotel)
        {
            Hoteis.RemoveAll(x => x.GetId() == idHotel);
            return Ok(Hoteis);
        }
    }
}