namespace ProjetoRedeHoteis.Lib.Models
{
    public class CategoriaQuarto : ModelBase
    {
        private string Nome { get; set; }
        private string Descricao { get; set; }
        private int OcupacaoMaxima { get; set; }
        private int CamaCasal { get; set; }
        private int CamaSolteiro { get; set; }
        private double Valor { get; set; }
        public CategoriaQuarto(int id, DateTime dataCadastro, DateTime dataUltimaAtualizacao, string nome, string descricao,
                               int ocupacaoMaxima, int camaCasal, int camaSolteiro, double valor) : base(id, dataCadastro,
                               dataUltimaAtualizacao)
        {
            SetNome(nome);
            SetDescricao(descricao);
            SetOcupacaoMaxima(ocupacaoMaxima);
            SetCamaCasal(camaCasal);
            SetCamaSolteiro(camaSolteiro);
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
    }
}