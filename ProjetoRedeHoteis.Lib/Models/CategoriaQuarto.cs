using ProjetoRedeHoteis.Lib.MyExceptions;

namespace ProjetoRedeHoteis.Lib.Models
{
    public class CategoriaQuarto : ModelBase
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public int OcupacaoMaxima { get; private set; }
        public int CamaCasal { get; private set; }
        public int CamaSolteiro { get; private set; }
        public double Valor { get; private set; }
        public virtual List<Quarto> Quartos { get; set; }
        protected CategoriaQuarto()
        {
            
        }
        public CategoriaQuarto(int id, DateTime dataCadastro, DateTime dataUltimaAtualizacao, string nome, string descricao,
                               int ocupacaoMaxima, int camaCasal, int camaSolteiro, double valor) : base(id, dataCadastro,
                               dataUltimaAtualizacao)
        {
            SetNome(nome);
            SetDescricao(descricao);
            SetCamaCasal(camaCasal);
            SetCamaSolteiro(camaSolteiro);
            SetOcupacaoMaxima(ocupacaoMaxima);
            SetValor(valor);
        }
        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public string GetDescricao()
        {
            return Descricao;
        }
        public void SetDescricao(string descricao)
        {
            Descricao = descricao;
        }
        public int GetOcupacaoMaxima()
        {
            return OcupacaoMaxima;
        }
        public void SetOcupacaoMaxima(int ocupacaoMaxima)
        {
            ValidarOcupacaoMaxima(ocupacaoMaxima);
            OcupacaoMaxima = ocupacaoMaxima;
        }
        public int GetCamaCasal()
        {
            return CamaCasal;
        }
        public void SetCamaCasal(int camaCasal)
        {
            CamaCasal = camaCasal;
        }
        public int GetCamaSolteiro()
        {
            return CamaSolteiro;
        }
        public void SetCamaSolteiro(int camaSolteiro)
        {
            CamaSolteiro = camaSolteiro;
        }
        public double GetValor()
        {
            return Valor;
        }
        public void SetValor(double valor)
        {
            Valor = valor;
        }
        public void ValidarOcupacaoMaxima(int ocupacaoMaxima)
        {
            var capacidadeMax = ((CamaCasal * 2) + (CamaSolteiro * 1));
            if (ocupacaoMaxima == capacidadeMax)
            {
                return;
            }
            throw new ValidacaoDadosException("Ocupação máxima não pode ser maior do que a quantidade de pessoas suportadas pelas camas!");
        }
    }
}