using EspacoCar.Api.Models.ProdutoModels;

namespace EspacoCar.Api.Repositories.Contratos
{
    public interface IProdutoEntradaRepositorio
    {
        EntradaDeProduto BuscarPorId(Guid id);
        IEnumerable<EntradaDeProduto> BuscarTodos();
        void Cadastrar(EntradaDeProduto entrada);
        void Atualizar(EntradaDeProduto entrada);
        void Deletar(Guid id);
    }
}