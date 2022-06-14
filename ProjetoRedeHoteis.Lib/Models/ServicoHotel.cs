namespace ProjetoRedeHoteis.Lib.Models
{
    public class ServicoHotel : ModelBase
    {
        private int IdServico { get; set; }
        private int IdHotel { get; set; }
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