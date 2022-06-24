using ProjetoRedeHoteis.Lib.Models;

namespace ProjetoRedeHoteis.Lib.Data.Repositorios
{
    public class EstadiaHospedeRepositorio : RepositorioBase<EstadiaHospede>
    {
        public EstadiaHospedeRepositorio(RedeHoteisContext context) : base(context, context.EstadiasHospedes)
        {

        }
    }
}