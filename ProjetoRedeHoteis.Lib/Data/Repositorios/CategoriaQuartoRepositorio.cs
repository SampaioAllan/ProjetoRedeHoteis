using ProjetoRedeHoteis.Lib.Models;

namespace ProjetoRedeHoteis.Lib.Data.Repositorios
{
    public class CategoriaQuartoRepositorio : RepositorioBase<CategoriaQuarto>
    {
        public CategoriaQuartoRepositorio(RedeHoteisContext context) : base(context, context.CategoriasQuarto)
        {
            
        }
    }
}