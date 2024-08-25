using EspacoCar.Api.Models;
using Flunt.Validations;

namespace EspacoCar.Api.validators
{
    public class ValidacaoDeProduto : Contract<Produto>
    {
        public ValidacaoDeProduto(Produto produto)
        {
            Requires()
                .IsNotNullOrEmpty(produto.Nome, "Nome", "O nome do produto deve ser informado")
                .IsLowerThan(produto.Nome, 50, "Nome", "O nome do produto deve ter no maximo 50 caracteres")
                .IsGreaterOrEqualsThan(produto.Estoque, 0, "Estoque", "O estoque não deve ser negativo")
                .IsGreaterOrEqualsThan(produto.Preco, 0, "Preco", "O preco não deve ser negativo")
                .IsGreaterOrEqualsThan(produto.Custo, 0, "Custo", "O preco não deve ser negativo")
                .AreNotEquals(produto.CategoriaId, Guid.Empty, "CategoriaId", "A categoria deve ser informada");
        }
    }
}