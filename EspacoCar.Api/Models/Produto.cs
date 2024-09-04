using EspacoCar.Api.Models.ProdutoModels;
using EspacoCar.Api.validators;
using Flunt.Notifications;

namespace EspacoCar.Api.Models
{
    public class Produto : Notifiable<Notification>
    {
        public Produto(string nome, int estoque, decimal preco, decimal custo, Guid categoriaId)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Estoque = estoque;
            Preco = preco;
            Custo = custo;
            CategoriaId = categoriaId;

            AddNotifications(new ValidacaoDeProduto(this));
        }

        public Guid Id { get; private set; }
        public int Numero { get; private set; }
        public string Nome { get; private set; }
        public int Estoque { get; private set; }
        public decimal Preco { get; private set; }
        public decimal Custo { get; private set; }
        public Guid CategoriaId { get; private set; }
        public virtual CategoriaDeProduto Categoria { get; private set; }
        public ICollection<SaidaDeProduto> SaidaDeProduto { get; private set; }
        public ICollection<EntradaDeProduto> EntradaDeProduto { get; private set; }
    }
}