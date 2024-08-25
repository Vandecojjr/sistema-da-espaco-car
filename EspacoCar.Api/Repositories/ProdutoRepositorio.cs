using EspacoCar.Api.Data;
using EspacoCar.Api.Models;
using EspacoCar.Api.Repositories.Contratos;

namespace EspacoCar.Api.Repositories
{
    public class ProdutoRepositorio : Repositorio, IProdutoRepositorio
    {
        public ProdutoRepositorio(DataContext context) : base(context)
        {
        }

        public void Atualizar(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Produto BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Produto> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Produto novoProduto)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}