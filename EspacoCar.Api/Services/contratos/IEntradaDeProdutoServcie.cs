using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EspacoCar.Api.DTOs;
using EspacoCar.Api.Models.ProdutoModels;
using EspacoCar.Api.Results;

namespace EspacoCar.Api.Services.contratos
{
    public interface IEntradaDeProdutoServcie
    {
        ResultadoGenerico Cadastrar(MovimentacaoDeProdutoDTO entrada);
        EntradaDeProduto BuscarPorId(Guid id);
        ICollection<EntradaDeProduto> BuscarTodos();
        ResultadoGenerico Atualizar(AtualizarMovimentacaoDeProdutoDTO entrada);
        ResultadoGenerico Deletar(Guid id);
    }
}