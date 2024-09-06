using EspacoCar.Api.DTOs;
using EspacoCar.Api.Models.ProdutoModels;
using EspacoCar.Api.Repositories.Contratos;
using EspacoCar.Api.Results;
using EspacoCar.Api.Services.contratos;

namespace EspacoCar.Api.Services
{
    public class SaidaDeProdutoService : ISaidaDeProdutoServcie
    {
        IProdutoSaidaRepositorio _repositorio;
        IProdutoService _produtoService;
        public SaidaDeProdutoService(IProdutoSaidaRepositorio repositorio, IProdutoService produtoService)
        {
            _repositorio = repositorio;
            _produtoService = produtoService;
        }

        public ResultadoGenerico Atualizar(AtualizarMovimentacaoDeProdutoDTO saida)
        {
            var saidaDeProduto = _repositorio.BuscarPorId(saida.Id);
            saidaDeProduto.Atualizar(saida);
            if (!saidaDeProduto.IsValid)
                return new ResultadoGenerico(false, "Ocorreu um erro ao atualizar a saida de produto", saidaDeProduto.Notifications);
            _repositorio.Atualizar(saidaDeProduto);
            return new ResultadoGenerico(true, "Atualizado com sucesso", saidaDeProduto);
        }

        public SaidaDeProduto BuscarPorId(Guid id)
        {
            return _repositorio.BuscarPorId(id);
        }


        public ICollection<SaidaDeProduto> BuscarTodos()
        {
            return _repositorio.BuscarTodos();
        }

        public ResultadoGenerico Cadastrar(MovimentacaoDeProdutoDTO saida)
        {
            var novaSaida = new SaidaDeProduto(saida.Quantidade, saida.ProdutoId);
            if (!novaSaida.IsValid)
                return new ResultadoGenerico(false, "Ocorreu um erro ao cadastrar a entrada de produto", novaSaida.Notifications);

            _repositorio.Cadastrar(novaSaida);
            _produtoService.DiminuirEstoque(saida.ProdutoId, saida.Quantidade);
            return new ResultadoGenerico(true, "Entrada de Produto Cadastrada com sucesso", novaSaida);
        }


        public ResultadoGenerico Deletar(Guid id)
        {
            var saida = _repositorio.BuscarPorId(id);
            _repositorio.Deletar(id);
            _produtoService.AumentarEstoque(saida.ProdutoId, saida.Quantidade);
            return new ResultadoGenerico(true, "Removido com sucesso", saida);
        }
    }
}