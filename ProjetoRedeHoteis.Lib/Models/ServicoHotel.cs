namespace ProjetoRedeHoteis.Lib.Models
{
    public class ServicoHotel : ModelBase
    {
        public int IdServico { get; private set; }
        public int IdHotel { get; private set; }
        public virtual Servico Servico { get; set; }
        public virtual Hotel Hotel { get; set; }
        protected ServicoHotel()
        {
            
        }
        public ServicoHotel(int id, DateTime dataCadastro, DateTime dataUltimaAtualizacao, int idServico, int idHotel) : base
                           (id, dataCadastro, dataUltimaAtualizacao)
        {
            SetIdServico(idServico);
            SetIdHotel(idHotel);
        }
        public int GetIdServico()
        {
            return IdServico;
        }
        public void SetIdServico(int idServico)
        {
            IdServico = idServico;
        }
        public int GetIdHotel()
        {
            return IdHotel;
        }
        public void SetIdHotel(int idHotel)
        {
            IdHotel = idHotel;
        }
    }
}