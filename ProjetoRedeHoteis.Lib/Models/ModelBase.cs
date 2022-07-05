using ProjetoRedeHoteis.Lib.MyExceptions;

namespace ProjetoRedeHoteis.Lib.Models
{
    public class ModelBase
    {
        public int Id { get; private set; }
        public DateTime DataCadastroTabela { get; private set; }
        public DateTime DataUltimaAtualizacaoTabela { get; private set; }
        protected ModelBase()
        {
            
        }
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
            return DataCadastroTabela;
        }
        public void SetDataCadastro(DateTime dataCadastro)
        {
            DataCadastroTabela = dataCadastro;
        }
        public DateTime GetDataUltimaAtualizacao()
        {
            return DataUltimaAtualizacaoTabela;
        }
        public void SetDataUltimaAtualizacao(DateTime dataUltimaAtualizacao)
        {
            ValidarDataUltimaAtualizacao(dataUltimaAtualizacao);
            DataUltimaAtualizacaoTabela = dataUltimaAtualizacao;
        }
        public void ValidarDataUltimaAtualizacao(DateTime dataUltimaAtualizacao)
        {
            if (dataUltimaAtualizacao >= DataCadastroTabela)
            {
                return;
            }
            throw new ValidacaoDadosException("Data da ultima atualização não pode ser anterior a data de cadastro!");
        }
    }
}