using EspacoCar.Api.Data;
using EspacoCar.Api.Models;
using EspacoCar.Api.Repositories.Contratos;
using Microsoft.EntityFrameworkCore;

namespace EspacoCar.Api.Repositories
{
    public class ProdutoCategoriaRepositorio : Repositorio, IProdutoCategoriaRepositorio
    {
        public ProdutoCategoriaRepositorio(DataContext context) : base(context)
        {
        }

        public void Cadastrar(CategoriaDeProduto categoria)
        {
            _context.Add(categoria);
            _context.SaveChanges();
        }
        public CategoriaDeProduto BuscarPorId(Guid id)
        {
            return _context.CategoriaDeProdutos.AsNoTracking().Where(x => x.Id == id).First();
        }

        public ICollection<CategoriaDeProduto> BuscarTodos()
        {
            return _context.CategoriaDeProdutos.AsNoTracking().ToList();
        }

        public void Atualizar(CategoriaDeProduto categoria)
        {
            _context.Entry<CategoriaDeProduto>(categoria).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            _context.CategoriaDeProdutos.Remove(BuscarPorId(id));
            _context.SaveChanges();
        }
    }
}