namespace EspacoCar.Api.Models.ProdutoModels
{
    public class EntradaDeProduto : MovimentacaoDeProduto
    {
        public EntradaDeProduto(int quantidade, Guid produtoId) : base(quantidade, produtoId)
        {
        }

    }
}