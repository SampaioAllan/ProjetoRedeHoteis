using ProjetoRedeHoteis.Lib.Data.Repositorios.Interfaces;
using ProjetoRedeHoteis.Lib.Models;

namespace ProjetoRedeHoteis.Lib.Data.Repositorios
{
    public class EstadiaRepositorio : RepositorioBase<Estadia>, IEstadiaRepositorio
    {
        public EstadiaRepositorio(RedeHoteisContext context) : base(context, context.Estadias)
        {

        }
    }
}