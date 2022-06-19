using ProjetoRedeHoteis.Lib.Models;
using ProjetoRedeHoteis.Lib.MyExceptions;
using Xunit;

namespace ProjetoRedeHoteis.TesteUnitario
{
    public class HospedeTest
    {
        [Fact]
        public void TestandoSeHospedeNaoSalvaTelefoneIncorreto()
        {
            //Arrange - Preparando
            var telefoneIncorreto = "999";
            //Act e Assert
            var exceptionTest = Assert.Throws<ValidacaoDadosException>(() => new Hospede(1, System.DateTime.MinValue, System.DateTime.Now,
                                                                                         "hospede", telefoneIncorreto, "11122233344",
                                                                                         "email@email.com", System.DateOnly.MinValue));
            Assert.Equal("Número de telefone deve ter 14 caracteres!", exceptionTest.Message);
        }
        [Fact]
        public void TestandoSeHospedeNaoSalvaCpfIncorreto()
        {
            //Arrange - Preparando
            var cpfIncorreto = "111222333ab";
            //Act e Assert
            var exceptionTest = Assert.Throws<ValidacaoDadosException>(() => new Hospede(1, System.DateTime.MinValue, System.DateTime.Now,
                                                                                         "hospede", "55051999887766", cpfIncorreto,
                                                                                         "email@email.com", System.DateOnly.MinValue));
            Assert.Equal("CPF deve conter apenas números!", exceptionTest.Message);
        }
        [Fact]
        public void TestandoSeHospedeNaoSalvaEmailIncorreto()
        {
            //Arrange - Preparando
            var emailIncorreto = "email-email.com";
            //Act e Assert
            var exceptionTest = Assert.Throws<ValidacaoDadosException>(() => new Hospede(1, System.DateTime.MinValue, System.DateTime.Now,
                                                                                         "hospede", "55051999887766", "11122233344",
                                                                                         emailIncorreto, System.DateOnly.MinValue));
            Assert.Equal("Email deve conter @!", exceptionTest.Message);
        }
    }
}