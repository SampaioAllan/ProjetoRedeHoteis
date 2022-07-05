using Microsoft.EntityFrameworkCore;
using ProjetoRedeHoteis.Lib.Data.Repositorios.Interfaces;
using ProjetoRedeHoteis.Lib.Models;

namespace ProjetoRedeHoteis.Lib.Data.Repositorios
{
    public class RepositorioBase<T> : IRepositorioBase<T> where T : ModelBase
    {
        protected readonly RedeHoteisContext _context;
        protected readonly DbSet<T> _dbSet;
        public RepositorioBase(RedeHoteisContext context, DbSet<T> dbSet)
        {
            _context = context;
            _dbSet = dbSet;
        }
        public void Adicionar(T item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
        }
        public T BuscarPorId(int id)
        {
            return _dbSet.AsNoTracking().First(x => x.GetId() == id);
        }
        public List<T> BuscarTodos()
        {
            return _dbSet.AsNoTracking().ToList();
        }
        public void DeletarItemDesejado(int id)
        {
            var itemARemover = _dbSet.Find(id);
            _dbSet.Remove(itemARemover);
            _context.SaveChanges();
        }
    }
}