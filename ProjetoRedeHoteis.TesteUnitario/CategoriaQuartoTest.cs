using ProjetoRedeHoteis.Lib.Models;
using ProjetoRedeHoteis.Lib.MyExceptions;
using Xunit;

namespace ProjetoRedeHoteis.TesteUnitario
{
    public class CategoriaQuartoTest
    {
        [Fact]
        public void TestandoSeCategoriaQuartoNaoSalvaOcupacaoMaximaIncorreta()
        {
            //Arrange - Preparando
            var ocupacaoIncorreta = 999;
            //Act e Assert
            var exceptionTest = Assert.Throws<ValidacaoDadosException>(() => new CategoriaQuarto(1, System.DateTime.MinValue,
                                                                       System.DateTime.Now, "Quarto Teste", "Criado para testes",
                                                                       ocupacaoIncorreta, 1, 1, 150));
            Assert.Equal("Ocupação máxima não pode ser maior do que a quantidade de pessoas suportadas pelas camas!", exceptionTest.Message);
        }
    }
}