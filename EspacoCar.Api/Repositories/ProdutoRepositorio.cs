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
            return _context.Produtos.AsNoTracking().Where(x => x.Id == id).First();
        }

        public ICollection<Produto> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Produto produto)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}