using EspacoCar.Api.Data;
using EspacoCar.Api.Models;
using EspacoCar.Api.Repositories.Contratos;

namespace EspacoCar.Api.Repositories
{
    public class ProdutoCategoriaRepositorio : Repositorio, IProdutoCategoriaRepositorio
    {
        public ProdutoCategoriaRepositorio(DataContext context) : base(context)
        {
        }

        public void Atualizar(CategoriaDeProduto categoria)
        {
            throw new NotImplementedException();
        }

        public CategoriaDeProduto BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public ICollection<CategoriaDeProduto> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(CategoriaDeProduto categoria)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}