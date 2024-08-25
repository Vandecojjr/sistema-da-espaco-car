using EspacoCar.Api.Models;
using Flunt.Validations;

namespace EspacoCar.Api.validators.ProdutoValidator
{
    public class ValidacaoDeMovimentacaoDeProduto : Contract<MovimentacaoDeProduto>
    {
        public ValidacaoDeMovimentacaoDeProduto(MovimentacaoDeProduto movimentacaoDeProduto)
        {
            Requires()
                .IsLowerThan(0, movimentacaoDeProduto.Quantidade, "Quantidade", "A quantidade deve ser positiva")
                .AreNotEquals(movimentacaoDeProduto.ProdutoId, Guid.Empty, "ProdutoId", "O id do produto deve ser informado");
        }
    }
}