namespace EspacoCar.Api.DTOs
{
    public class AtualizarProdutoDTO
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Estoque { get; set; }
        public decimal Preco { get; set; }
        public decimal Custo { get; set; }
        public Guid CategoriaId { get; set; }
    }
}