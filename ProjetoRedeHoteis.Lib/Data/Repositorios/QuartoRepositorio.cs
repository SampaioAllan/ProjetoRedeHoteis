using ProjetoRedeHoteis.Lib.Models;

namespace ProjetoRedeHoteis.Lib.Data.Repositorios
{
    public class QuartoRepositorio : RepositorioBase<Quarto>
    {
        public QuartoRepositorio(RedeHoteisContext context) : base(context, context.Quartos)
        {

        }

    }
}