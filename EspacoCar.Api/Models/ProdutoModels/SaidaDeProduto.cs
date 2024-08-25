namespace EspacoCar.Api.Models.ProdutoModels
{
    public class SaidaDeProduto : MovimentacaoDeProduto
    {
        public SaidaDeProduto(int quantidade, Guid produtoId) : base(quantidade, produtoId)
        {
        }
    }
}