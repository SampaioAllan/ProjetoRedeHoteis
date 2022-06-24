using ProjetoRedeHoteis.Lib.Models;

namespace ProjetoRedeHoteis.Lib.Data.Repositorios
{
    public class EstadiaRepositorio : RepositorioBase<Estadia>
    {
        public EstadiaRepositorio(RedeHoteisContext context) : base(context, context.Estadias)
        {

        }
    }
}