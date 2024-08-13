namespace EspacoCar.Api.Models
{
    public class Categoria
    {
        public Categoria(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
    }
}