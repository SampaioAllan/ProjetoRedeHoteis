using ProjetoRedeHoteis.Lib.Data.Repositorios.Interfaces;
using ProjetoRedeHoteis.Lib.Models;

namespace ProjetoRedeHoteis.Lib.Data.Repositorios
{
    public class ServicoHotelRepositorio : RepositorioBase<ServicoHotel>, IServicoHotelRepositorio
    {
        public ServicoHotelRepositorio(RedeHoteisContext context) : base(context, context.ServicosHoteis)
        {

        }

    }
}