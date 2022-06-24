using ProjetoRedeHoteis.Lib.Models;

namespace ProjetoRedeHoteis.Lib.Data.Repositorios
{
    public class ServicoHotelRepositorio : RepositorioBase<ServicoHotel>
    {
        public ServicoHotelRepositorio(RedeHoteisContext context) : base(context, context.ServicosHoteis)
        {

        }

    }
}