namespace ProjetoRedeHoteis.Lib.Models
{
    public class Servico : ModelBase
    {
        public string Nome { get; private set; }
        public virtual List<ServicoHotel> ServicosHoteis { get; set; }
        protected Servico()
        {
            
        }
        public Servico(int id, DateTime dataCadastro, DateTime dataUltimaAtualizacao, string nome) : base(id,
                       dataCadastro, dataUltimaAtualizacao)
        {
            SetNome(nome);
        }
        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
    }
}