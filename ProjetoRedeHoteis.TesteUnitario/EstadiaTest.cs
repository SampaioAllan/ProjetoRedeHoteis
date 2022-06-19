using ProjetoRedeHoteis.Lib.Models;
using ProjetoRedeHoteis.Lib.MyExceptions;
using Xunit;

namespace ProjetoRedeHoteis.TesteUnitario
{
    public class EstadiaTest
    {
        [Fact]
        public void TestandoSeEstadiaNaoSalvaDataSaidaIncorreta()
        {
            //Arrange - Preparando
            var dataIncorreta = System.DateOnly.MinValue;
            //Act e Assert
            var exceptionTest = Assert.Throws<ValidacaoDadosException>(() => new Estadia(1, System.DateTime.MinValue, System.DateTime.Now,
                                                                       System.DateOnly.MaxValue, dataIncorreta, 500, 1, 1));
            Assert.Equal("Data de saída deve ser posterior a data de entrada!", exceptionTest.Message);
        }
    }
}