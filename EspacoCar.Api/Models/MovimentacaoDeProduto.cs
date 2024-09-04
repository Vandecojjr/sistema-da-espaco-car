using EspacoCar.Api.validators.ProdutoValidator;
using Flunt.Notifications;

namespace EspacoCar.Api.Models
{
    public class MovimentacaoDeProduto : Notifiable<Notification>
    {
        public MovimentacaoDeProduto(int quantidade, Guid produtoId)
        {
            Id = Guid.NewGuid();
            Quantidade = quantidade;
            Data = DateTime.Now;
            ProdutoId = produtoId;

            AddNotifications(new ValidacaoDeMovimentacaoDeProduto(this));
        }

        public Guid Id { get; private set; }
        public int Quantidade { get; private set; }
        public DateTime Data { get; private set; }
        public Guid ProdutoId { get; private set; }
        public Produto Produto { get; private set; }
    }
}