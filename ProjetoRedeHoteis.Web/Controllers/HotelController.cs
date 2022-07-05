using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using ProjetoRedeHoteis.Lib.Data.Repositorios.Interfaces;
using ProjetoRedeHoteis.Lib.Models;
using ProjetoRedeHoteis.Web.DTOs;
using ProjetoRedeHoteis.Web.DTOs.RespostaHTTP;

namespace ProjetoRedeHoteis.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HotelController : ControllerBase
    {
        private readonly IHotelRepositorio _repositorio;
        public HotelController(IHotelRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpPost("Adicionar CategoriaQuarto")]
        public IActionResult AddHotel(HotelDTO hotel)
        {
            var hotelNovo = new Hotel(hotel.Id, hotel.DataCadastroTabela, hotel.DataUltimaAtualizacaoTabela, hotel.Nome, hotel.Endereco,
                                      hotel.Cep, hotel.Descricao, hotel.Telefone, hotel.Email, hotel.HorarioCheckIn,
                                      hotel.HorarioCheckOut);
            _repositorio.Adicionar(hotelNovo);
            return Ok();
        }
        [HttpGet("Buscar Hoteis")]
        public IActionResult GetHoteis()
        {
            return Ok(_repositorio.BuscarTodos());
        }
        [HttpGet("Buscar Hotel por Id")]
        public IActionResult GetHotelPorId(int idHotel)
        {
            return Ok(_repositorio.BuscarPorId(idHotel));
        }
        [HttpDelete("Deletar Hotel por Id")]
        public IActionResult DeleteHotelPorId(int idHotel)
        {
            _repositorio.DeletarItemDesejado(idHotel);
            return Ok();
        }
        [HttpGet("CEP")]
        public async Task<IActionResult> GetCEP(string cep)
        {
            var client = new HttpClient();
            var retorno = await client.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
            var resposta = await retorno.Content.ReadAsStringAsync();

            var respostaEmObjeto = JsonSerializer.Deserialize<ViaCepRespostaHTTP>(resposta);
            //return Ok(resposta);
            return Ok($"cidade:{respostaEmObjeto.localidade}\n Bairro:{respostaEmObjeto.bairro}");
        }
    }
}