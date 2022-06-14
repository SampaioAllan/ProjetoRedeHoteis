namespace ProjetoRedeHoteis.Lib.Models
{
    public class Servico : ModelBase
    {
        private string Nome { get; set; }
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