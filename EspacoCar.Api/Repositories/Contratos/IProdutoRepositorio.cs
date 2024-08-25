using EspacoCar.Api.Models;

namespace EspacoCar.Api.Repositories.Contratos
{
    public interface IProdutoRepositorio
    {
        Produto BuscarPorId(Guid id);
        ICollection<Produto> BuscarTodos();
        void Cadastrar(Produto novoProduto);
        void Atualizar(Produto produto);
        void Deletar(Guid id);
    }
}