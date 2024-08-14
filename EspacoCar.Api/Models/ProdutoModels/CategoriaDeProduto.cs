using EspacoCar.Api.validators;
using Flunt.Notifications;

namespace EspacoCar.Api.Models
{
    public class CategoriaDeProduto : Notifiable<Notification>
    {
        public CategoriaDeProduto(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;

            AddNotifications(new ValidacaoDeCategoria(this));
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
    }
}