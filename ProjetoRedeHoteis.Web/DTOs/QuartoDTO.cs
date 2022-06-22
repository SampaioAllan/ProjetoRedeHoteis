namespace ProjetoRedeHoteis.Web.DTOs
{
    public class QuartoDTO : ModelBaseDTO
    {
        public int Numero { get; set; }
        public int Andar { get; set; }
        public int IdCategoria { get; set; }
        public int IdHotel { get; set; }
        public QuartoDTO()
        {

        }
    }
}