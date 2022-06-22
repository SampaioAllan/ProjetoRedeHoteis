namespace ProjetoRedeHoteis.Web.DTOs
{
    public class ServicoHotelDTO : ModelBaseDTO
    {
        public int IdServico { get; set; }
        public int IdHotel { get; set; }
        public ServicoHotelDTO()
        {

        }
    }
}