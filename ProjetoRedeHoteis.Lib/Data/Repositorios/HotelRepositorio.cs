using ProjetoRedeHoteis.Lib.Models;

namespace ProjetoRedeHoteis.Lib.Data.Repositorios
{
    public class HotelRepositorio : RepositorioBase<Hotel>
    {
        public HotelRepositorio(RedeHoteisContext context) : base(context, context.Hoteis)
        {

        }
    }
}