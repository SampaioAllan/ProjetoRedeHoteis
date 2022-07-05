namespace ProjetoRedeHoteis.Web.DTOs
{
    public class ModelBaseDTO
    {
        public int Id { get; set; }
        public DateTime DataCadastroTabela { get; set; }
        public DateTime DataUltimaAtualizacaoTabela { get; set; }
        public ModelBaseDTO()
        {

        }
    }
}