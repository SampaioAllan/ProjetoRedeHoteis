using ProjetoRedeHoteis.Lib.Data.Repositorios.Interfaces;
using ProjetoRedeHoteis.Lib.Models;

namespace ProjetoRedeHoteis.Lib.Data.Repositorios
{
    public class CategoriaQuartoRepositorio : RepositorioBase<CategoriaQuarto>, ICategoriaQuartoRepositorio
    {
        public CategoriaQuartoRepositorio(RedeHoteisContext context) : base(context, context.CategoriasQuarto)
        {
            
        }
    }
}