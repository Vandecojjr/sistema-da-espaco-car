using EspacoCar.Api.Data;
using EspacoCar.Api.Models.ProdutoModels;
using EspacoCar.Api.Repositories.Contratos;

namespace EspacoCar.Api.Repositories
{
    public class ProdutoEntradaRepositorio : Repositorio, IProdutoEntradaRepositorio
    {
        public ProdutoEntradaRepositorio(DataContext context) : base(context)
        {
        }

        public void Atualizar(EntradaDeProduto entrada)
        {
            throw new NotImplementedException();
        }

        public EntradaDeProduto BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EntradaDeProduto> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(EntradaDeProduto entrada)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}