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

        public ICollection<Produto> BuscarTodos()
        {
            return _repositorio.BuscarTodos();
        }

        public ResultadoGenerico Atualizar(AtualizarProdutoDTO produtoDTO)
        {
            var produto = _repositorio.BuscarPorId(produtoDTO.Id);
            produto.Atualizar(produtoDTO);

            if (!produto.IsValid)
                return new ResultadoGenerico(false, "Ocorreu um erro ao atualizar o produto", produto.Notifications);

            _repositorio.Atualizar(produto);
            return new ResultadoGenerico(true, "Atualizado com sucesso", produto);
        }

        public ResultadoGenerico Remover(Guid id)
        {
            _repositorio.Deletar(id);
            return new ResultadoGenerico(true, "Removido com sucesso", null);
        }

        public void AumentarEstoque(Guid id, int quantidade)
        {
            var produto = _repositorio.BuscarPorId(id);
            produto.AumentarEstoque(quantidade);
            _repositorio.Atualizar(produto);
        }

        public void DiminuirEstoque(Guid id, int quantidade)
        {
            var produto = _repositorio.BuscarPorId(id);
            produto.DiminuirEstoque(quantidade);
            _repositorio.Atualizar(produto);
        }
    }
}