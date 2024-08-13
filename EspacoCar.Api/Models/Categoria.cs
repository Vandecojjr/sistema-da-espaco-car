using System.ComponentModel.DataAnnotations;

namespace EspacoCar.Api.Models
{
    public class Categoria
    {
        public Categoria(string nome)
        {
            Nome = nome;
        }


        public Guid Id { get { return Guid.NewGuid(); } }
        public string Nome { get; private set; }
    }
}