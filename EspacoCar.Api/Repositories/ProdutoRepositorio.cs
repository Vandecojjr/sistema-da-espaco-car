using EspacoCar.Api.Data;
using EspacoCar.Api.Models;
using EspacoCar.Api.Repositories.Contratos;
using Microsoft.EntityFrameworkCore;

namespace EspacoCar.Api.Repositories
{
    public class ProdutoRepositorio : Repositorio, IProdutoRepositorio
    {
        public ProdutoRepositorio(DataContext context) : base(context)
        {
        }

        public void Cadastrar(Produto novoProduto)
        {
            _context.Add(novoProduto);
            _context.SaveChanges();
        }

        public Produto BuscarPorId(Guid id)
        {
            return _context.Produtos.Where(x => x.Id == id).First();
        }

        public ICollection<Produto> BuscarTodos()
        {
            return _context.Produtos.AsNoTracking().ToList();
        }

        public void Atualizar(Produto produto)
        {
            _context.Entry<Produto>(produto).State = EntityState.Modified;
            _context.Entry(produto).Property(p => p.Numero).IsModified = false;
            _context.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            _context.Produtos.Remove(BuscarPorId(id));
            _context.SaveChanges();
        }
    }
}