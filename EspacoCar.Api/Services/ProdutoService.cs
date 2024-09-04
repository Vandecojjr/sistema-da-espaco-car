using EspacoCar.Api.DTOs;
using EspacoCar.Api.Models;
using EspacoCar.Api.Repositories.Contratos;
using EspacoCar.Api.Results;
using EspacoCar.Api.Services.contratos;

namespace EspacoCar.Api.Services
{
    public class ProdutoService : IProdutoService
    {
        public IProdutoRepositorio _repositorio;

        public ProdutoService(IProdutoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public ResultadoGenerico Cadastrar(ProdutoDTO produtoDto)
        {
            var produto = new Produto(produtoDto.Nome, produtoDto.Estoque, produtoDto.Preco, produtoDto.Custo, produtoDto.CategoriaId);
            if (!produto.IsValid)
                return new ResultadoGenerico(false, "Ocorreu um erro ao cadastrar o produto", produto.Notifications);

            _repositorio.Cadastrar(produto);
            return new ResultadoGenerico(true, "Produto Cadastrado com sucesso", produto);
        }

        public Produto BuscarPorId(Guid id)
        {
            return _repositorio.BuscarPorId(id);
        }

        public IEnumerable<Produto> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public ResultadoGenerico Atualizar(Produto produto)
        {
            throw new NotImplementedException();
        }

        public ResultadoGenerico Remover(Guid id)
        {
            throw new NotImplementedException();
        }


    }
}