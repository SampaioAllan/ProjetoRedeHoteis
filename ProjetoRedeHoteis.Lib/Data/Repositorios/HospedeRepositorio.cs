using ProjetoRedeHoteis.Lib.Models;

namespace ProjetoRedeHoteis.Lib.Data.Repositorios
{
    public class HospedeRepositorio : RepositorioBase<Hospede>
    {
        public HospedeRepositorio(RedeHoteisContext context) : base(context, context.Hospedes)
        {

        }
    }
}