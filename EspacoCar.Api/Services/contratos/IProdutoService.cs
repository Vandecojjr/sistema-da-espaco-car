using EspacoCar.Api.DTOs;
using EspacoCar.Api.Models;
using EspacoCar.Api.Results;

namespace EspacoCar.Api.Services.contratos
{
    public interface IProdutoService
    {
        Produto BuscarPorId(Guid id);
        ICollection<Produto> BuscarTodos();
        ResultadoGenerico Cadastrar(ProdutoDTO produto);
        ResultadoGenerico Atualizar(AtualizarProdutoDTO produto);
        ResultadoGenerico Remover(Guid id);
    }
}