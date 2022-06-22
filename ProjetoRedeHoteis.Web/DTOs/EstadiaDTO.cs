namespace ProjetoRedeHoteis.Web.DTOs
{
    public class EstadiaDTO : ModelBaseDTO
    {
        public DateOnly DataEntrada { get; set; }
        public DateOnly DataSaida { get; set; }
        public double ValorTotal { get; set; }
        public int IdResponsavel { get; set; }
        public int IdQuarto { get; set; }
        public EstadiaDTO()
        {

        }
    }
}