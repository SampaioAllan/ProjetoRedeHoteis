using ProjetoRedeHoteis.Lib.Models;
using ProjetoRedeHoteis.Lib.MyExceptions;
using Xunit;

namespace ProjetoRedeHoteis.TesteUnitario
{
    public class ModelBaseTest
    {
        [Fact]
        public void TestandoSeModelBaseNaoSalvaDataUltimaAtualizacaoIncorreta()
        {
            //Arrange - Preparando
            var dataIncorreta = System.DateTime.Now;
            //Act e Assert
            var exceptionTest = Assert.Throws<ValidacaoDadosException>(() => new ModelBase(1, System.DateTime.MaxValue, dataIncorreta));
            Assert.Equal("Data da ultima atualização não pode ser anterior a data de cadastro!", exceptionTest.Message);
        }
    }
}