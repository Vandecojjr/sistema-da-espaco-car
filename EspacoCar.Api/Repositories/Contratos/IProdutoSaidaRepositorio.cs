using EspacoCar.Api.Models.ProdutoModels;

namespace EspacoCar.Api.Repositories.Contratos
{
    public interface IProdutoSaidaRepositorio
    {
        SaidaDeProduto BuscarPorId(Guid id);
        IEnumerable<SaidaDeProduto> BuscarTodos();
        void Cadastrar(SaidaDeProduto entrada);
        void Atualizar(SaidaDeProduto entrada);
        void Deletar(Guid id);
    }
}