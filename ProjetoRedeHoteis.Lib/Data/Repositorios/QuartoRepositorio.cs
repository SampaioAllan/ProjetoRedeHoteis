using ProjetoRedeHoteis.Lib.Data.Repositorios.Interfaces;
using ProjetoRedeHoteis.Lib.Models;

namespace ProjetoRedeHoteis.Lib.Data.Repositorios
{
    public class QuartoRepositorio : RepositorioBase<Quarto>, IQuartoRepositorio
    {
        public QuartoRepositorio(RedeHoteisContext context) : base(context, context.Quartos)
        {

        }

    }
}