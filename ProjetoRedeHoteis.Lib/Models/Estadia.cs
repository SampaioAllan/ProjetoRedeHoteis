using ProjetoRedeHoteis.Lib.MyExceptions;

namespace ProjetoRedeHoteis.Lib.Models
{
    public class Estadia : ModelBase
    {
        private DateOnly DataEntrada { get; set; }
        private DateOnly DataSaida { get; set; }
        private double ValorTotal { get; set; }
        private int IdResponsavel { get; set; }
        private int IdQuarto { get; set; }
        public virtual List<EstadiaHospede> EstadiasHospedes { get; set; }
        public virtual Quarto Quarto { get; set; }
        public virtual Hospede Responsavel { get; set; }
        public Estadia(int id, DateTime dataCadastro, DateTime dataUltimaAtualizacao, DateOnly dataEntrada, DateOnly dataSaida,
                       double valorTotal, int idResponsavel, int idQuarto) : base(id, dataCadastro, dataUltimaAtualizacao)
        {
            SetDataEntrada(dataEntrada);
            SetDataSaida(dataSaida);
            SetValorTotal(valorTotal);
            SetIdResponsavel(idResponsavel);
            SetIdQuarto(idQuarto);
        }
        public DateOnly GetDataEntrada()
        {
            return DataEntrada;
        }
        public void SetDataEntrada(DateOnly dataEntrada)
        {
            DataEntrada = dataEntrada;
        }
        public DateOnly GetDataSaida()
        {
            return DataSaida;
        }
        public void SetDataSaida(DateOnly dataSaida)
        {
            ValidarDataSaida(dataSaida);
            DataSaida = dataSaida;
        }
        public double GetValorTotal()
        {
            return ValorTotal;
        }
        public void SetValorTotal(double valorTotal)
        {
            ValorTotal = valorTotal;
        }
        public int GetIdResponsavel()
        {
            return IdResponsavel;
        }
        public void SetIdResponsavel(int idResponsavel)
        {
            IdResponsavel = idResponsavel;
        }
        public int GetIdQuarto()
        {
            return IdQuarto;
        }
        public void SetIdQuarto(int idQuarto)
        {
            IdQuarto = idQuarto;
        }
        public void ValidarDataSaida(DateOnly dataSaida)
        {
            if (dataSaida > DataEntrada)
            {
                return;
            }
            throw new ValidacaoDadosException("Data de saída deve ser posterior a data de entrada!");
        }
    }
}