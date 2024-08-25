using EspacoCar.Api.Models;

namespace EspacoCar.Api.Repositories.Contratos
{
    public interface IProdutoCategoriaRepositorio
    {
        CategoriaDeProduto BuscarPorId(Guid id);
        ICollection<CategoriaDeProduto> BuscarTodos();
        void Cadastrar(CategoriaDeProduto categoria);
        void Atualizar(CategoriaDeProduto categoria);
        void Deletar(Guid id);
    }
}