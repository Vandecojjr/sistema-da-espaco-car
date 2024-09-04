using EspacoCar.Api.DTOs;
using EspacoCar.Api.Models;
using EspacoCar.Api.Repositories.Contratos;
using EspacoCar.Api.Results;
using EspacoCar.Api.Services.contratos;

namespace EspacoCar.Api.Services
{
    public class CategoriaDeProdutoService : ICategoriaDeProdutoService
    {
        public IProdutoCategoriaRepositorio _repositorio;

        public CategoriaDeProdutoService(IProdutoCategoriaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public ResultadoGenerico Cadastrar(CategoriaDeProdutoDTO categoriaDto)
        {
            var categoria = new CategoriaDeProduto(categoriaDto.Nome);
            if (!categoria.IsValid)
                return new ResultadoGenerico(false, "Ocorreu um erro ao cadastrar a categoria", categoria.Notifications);

            _repositorio.Cadastrar(categoria);
            return new ResultadoGenerico(true, "Categoria Cadastrada com sucesso", categoria);
        }

        public CategoriaDeProduto BuscarPorId(Guid id)
        {
            return _repositorio.BuscarPorId(id);
        }

        public IEnumerable<CategoriaDeProduto> BuscarTodos()
        {
            return _repositorio.BuscarTodos();
        }

        public ResultadoGenerico Atualizar(UpdateCategoriaDeProdutoDTO categoriaDto)
        {
            var categoria = _repositorio.BuscarPorId(categoriaDto.Id);
            categoria.Atualizar(categoriaDto.Nome);

            if (!categoria.IsValid)
                return new ResultadoGenerico(false, "Ocorreu um erro ao atualizar a categoria", categoria.Notifications);

            _repositorio.Atualizar(categoria);
            return new ResultadoGenerico(true, "Atualizado com sucesso", categoria);
        }

        public ResultadoGenerico Remover(Guid id)
        {
            _repositorio.Deletar(id);
            return new ResultadoGenerico(true, "Removido com sucesso", null);
        }
    }
}