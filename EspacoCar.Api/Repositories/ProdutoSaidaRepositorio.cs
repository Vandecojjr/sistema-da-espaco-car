using EspacoCar.Api.Data;
using EspacoCar.Api.Models.ProdutoModels;
using EspacoCar.Api.Repositories.Contratos;

namespace EspacoCar.Api.Repositories
{
    public class ProdutoSaidaRepositorio : Repositorio, IProdutoSaidaRepositorio
    {
        public ProdutoSaidaRepositorio(DataContext context) : base(context)
        {
        }

        public void Atualizar(SaidaDeProduto entrada)
        {
            throw new NotImplementedException();
        }

        public SaidaDeProduto BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SaidaDeProduto> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(SaidaDeProduto entrada)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}