using EspacoCar.Api.DTOs;
using EspacoCar.Api.Models.ProdutoModels;
using EspacoCar.Api.Repositories.Contratos;
using EspacoCar.Api.Results;
using EspacoCar.Api.Services.contratos;

namespace EspacoCar.Api.Services
{
    public class EntradaDeProdutoService : IEntradaDeProdutoServcie
    {
        IProdutoEntradaRepositorio _repositorio;
        IProdutoService _produtoService;
        public EntradaDeProdutoService(IProdutoEntradaRepositorio repositorio, IProdutoService produtoService)
        {
            _repositorio = repositorio;
            _produtoService = produtoService;
        }

        public ResultadoGenerico Atualizar(AtualizarMovimentacaoDeProdutoDTO entrada)
        {
            var entradaDeProduto = _repositorio.BuscarPorId(entrada.Id);
            entradaDeProduto.Atualizar(entrada);
            if (!entradaDeProduto.IsValid)
                return new ResultadoGenerico(false, "Ocorreu um erro ao atualizar a entrada de produto", entradaDeProduto.Notifications);
            _repositorio.Atualizar(entradaDeProduto);
            return new ResultadoGenerico(true, "Atualizado com sucesso", entradaDeProduto);
        }

        public EntradaDeProduto BuscarPorId(Guid id)
        {
            return _repositorio.BuscarPorId(id);
        }


        public ICollection<EntradaDeProduto> BuscarTodos()
        {
            return _repositorio.BuscarTodos();
        }

        public ResultadoGenerico Cadastrar(MovimentacaoDeProdutoDTO entrada)
        {
            var novaEntrada = new EntradaDeProduto(entrada.Quantidade, entrada.ProdutoId);
            if (!novaEntrada.IsValid)
                return new ResultadoGenerico(false, "Ocorreu um erro ao cadastrar a entrada de produto", novaEntrada.Notifications);

            _repositorio.Cadastrar(novaEntrada);
            _produtoService.AumentarEstoque(entrada.ProdutoId, entrada.Quantidade);
            return new ResultadoGenerico(true, "Entrada de Produto Cadastrada com sucesso", novaEntrada);
        }


        public ResultadoGenerico Deletar(Guid id)
        {
            var entrada = _repositorio.BuscarPorId(id);
            _repositorio.Deletar(id);
            _produtoService.DiminuirEstoque(entrada.ProdutoId, entrada.Quantidade);
            return new ResultadoGenerico(true, "Removido com sucesso", entrada);
        }
    }
}