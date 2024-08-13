using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace EspacoCar.Api.Models
{
    public class Produto
    {
        public Produto(int numero, string nome, int estoque, decimal preco, decimal precoDeCusto, Guid categoriaId)
        {
            Numero = numero;
            Nome = nome;
            Estoque = estoque;
            Preco = preco;
            PrecoDeCusto = precoDeCusto;
            CategoriaId = categoriaId;
        }

        public Guid Id { get { return Guid.NewGuid(); } }
        public int Numero { get; private set; }
        public string Nome { get; private set; }
        public int Estoque { get; private set; }
        public decimal Preco { get; private set; }
        public decimal PrecoDeCusto { get; private set; }
        public Guid CategoriaId { get; private set; }
        public Categoria Categoria { get; private set; }
    }
}