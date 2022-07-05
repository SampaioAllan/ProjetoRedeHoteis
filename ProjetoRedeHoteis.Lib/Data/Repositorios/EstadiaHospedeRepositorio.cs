using ProjetoRedeHoteis.Lib.Data.Repositorios.Interfaces;
using ProjetoRedeHoteis.Lib.Models;

namespace ProjetoRedeHoteis.Lib.Data.Repositorios
{
    public class EstadiaHospedeRepositorio : RepositorioBase<EstadiaHospede>, IEstadiaHospedeRepositorio
    {
        public EstadiaHospedeRepositorio(RedeHoteisContext context) : base(context, context.EstadiasHospedes)
        {

        }
    }
}