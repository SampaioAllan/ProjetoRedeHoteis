using ProjetoRedeHoteis.Lib.Data.Repositorios.Interfaces;
using ProjetoRedeHoteis.Lib.Models;

namespace ProjetoRedeHoteis.Lib.Data.Repositorios
{
    public class HotelRepositorio : RepositorioBase<Hotel>, IHotelRepositorio
    {
        public HotelRepositorio(RedeHoteisContext context) : base(context, context.Hoteis)
        {

        }
    }
}