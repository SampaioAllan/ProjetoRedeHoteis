namespace ProjetoRedeHoteis.Lib.Models
{
    public class ModelBase
    {
        private int Id { get; set; }
        private DateTime DataCadastro { get; set; }
        private DateTime DataUltimaAtualizacao { get; set; }
        public ModelBase(int id, DateTime dataCadastro, DateTime dataUltimaAtualizacao)
        {
            SetId(id);
            SetDataCadastro(dataCadastro);
            SetDataUltimaAtualizacao(dataUltimaAtualizacao);
        }
        public int GetId()
        {
            return Id;
        }
        public void SetId(int id)
        {
            Id = id;
        }
        public DateTime GetDataCadastro()
        {
            return DataCadastro;
        }
        public void SetDataCadastro(DateTime dataCadastro)
        {
            DataCadastro = dataCadastro;
        }
        public DateTime GetDataUltimaAtualizacao()
        {
            return DataUltimaAtualizacao;
        }
        public void SetDataUltimaAtualizacao(DateTime dataUltimaAtualizacao)
        {
            DataUltimaAtualizacao = dataUltimaAtualizacao;
        }
    }
}