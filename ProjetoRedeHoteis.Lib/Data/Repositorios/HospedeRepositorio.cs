using ProjetoRedeHoteis.Lib.Data.Repositorios.Interfaces;
using ProjetoRedeHoteis.Lib.Models;

namespace ProjetoRedeHoteis.Lib.Data.Repositorios
{
    public class HospedeRepositorio : RepositorioBase<Hospede>, IHospedeRepositorio
    {
        public HospedeRepositorio(RedeHoteisContext context) : base(context, context.Hospedes)
        {

        }
    }
}