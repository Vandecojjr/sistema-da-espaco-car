using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EspacoCar.Api.DTOs;
using EspacoCar.Api.Models.ProdutoModels;
using EspacoCar.Api.Results;

namespace EspacoCar.Api.Services.contratos
{
    public interface ISaidaDeProdutoServcie
    {
        ResultadoGenerico Cadastrar(MovimentacaoDeProdutoDTO saida);
        SaidaDeProduto BuscarPorId(Guid id);
        ICollection<SaidaDeProduto> BuscarTodos();
        ResultadoGenerico Atualizar(AtualizarMovimentacaoDeProdutoDTO saida);
        ResultadoGenerico Deletar(Guid id);
    }
}