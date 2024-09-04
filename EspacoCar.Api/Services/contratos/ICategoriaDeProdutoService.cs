using EspacoCar.Api.DTOs;
using EspacoCar.Api.Models;
using EspacoCar.Api.Results;

namespace EspacoCar.Api.Services.contratos
{
    public interface ICategoriaDeProdutoService
    {
        CategoriaDeProduto BuscarPorId(Guid id);
        IEnumerable<CategoriaDeProduto> BuscarTodos();
        ResultadoGenerico Cadastrar(CategoriaDeProdutoDTO categoriaDTO);
        ResultadoGenerico Atualizar(UpdateCategoriaDeProdutoDTO produto);
        ResultadoGenerico Remover(Guid id);
    }
}