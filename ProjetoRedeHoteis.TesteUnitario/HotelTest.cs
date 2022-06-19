using ProjetoRedeHoteis.Lib.Models;
using ProjetoRedeHoteis.Lib.MyExceptions;
using Xunit;

namespace ProjetoRedeHoteis.TesteUnitario
{
    public class HotelTest
    {
        [Fact]
        public void TestandoSeHotelNaoSalvaTelefoneIncorreto()
        {
            //Arrange - Preparando
            var telefoneIncorreto = "999";
            //Act e Assert
            var exceptionTest = Assert.Throws<ValidacaoDadosException>(() => new Hotel(1, System.DateTime.MinValue, System.DateTime.Now,
                                                                                       "hotel Teste", "endereço", "92480000", "hotel teste",
                                                                                       telefoneIncorreto, "email@email.com",
                                                                                       System.DateTime.MinValue, System.DateTime.Now));
            Assert.Equal("Número de telefone deve ter 14 caracteres!", exceptionTest.Message);
        }
        [Fact]
        public void TestandoSeHotelNaoSalvaEmailIncorreto()
        {
            //Arrange - Preparando
            var emailIncorreto = "email-email.com";
            //Act e Assert
            var exceptionTest = Assert.Throws<ValidacaoDadosException>(() => new Hotel(1, System.DateTime.MinValue, System.DateTime.Now,
                                                                                       "hotel Teste", "endereço", "92480000", "hotel teste",
                                                                                       "55051999887766", emailIncorreto,
                                                                                       System.DateTime.MinValue, System.DateTime.Now));
            Assert.Equal("Email deve conter @!", exceptionTest.Message);
        }
    }
}