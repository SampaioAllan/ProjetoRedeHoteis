using ProjetoRedeHoteis.Lib.Models;

namespace ProjetoRedeHoteis.Lib.Data.Repositorios
{
    public class ServicoRepositorio : RepositorioBase<Servico>
    {
        public ServicoRepositorio(RedeHoteisContext context) : base(context, context.Servicos)
        {

        }

    }
}