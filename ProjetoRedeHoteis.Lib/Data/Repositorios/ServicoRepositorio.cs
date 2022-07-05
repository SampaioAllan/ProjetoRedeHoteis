using ProjetoRedeHoteis.Lib.Data.Repositorios.Interfaces;
using ProjetoRedeHoteis.Lib.Models;

namespace ProjetoRedeHoteis.Lib.Data.Repositorios
{
    public class ServicoRepositorio : RepositorioBase<Servico>, IServicoRepositorio
    {
        public ServicoRepositorio(RedeHoteisContext context) : base(context, context.Servicos)
        {

        }

    }
}