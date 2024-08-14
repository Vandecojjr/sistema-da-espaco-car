using EspacoCar.Api.Models.ProdutoModels;
using Microsoft.EntityFrameworkCore;

namespace EspacoCar.Api.Data
{
    public partial class DataContext
    {
        public void ConfigurarEntradaDeProduto(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EntradaDeProduto>()
                .HasKey(entrada => entrada.Id);

            modelBuilder.Entity<EntradaDeProduto>()
                .Property(entrada => entrada.Quantidade)
                .IsRequired();

            modelBuilder.Entity<EntradaDeProduto>()
                .Property(entrada => entrada.Data)
                .IsRequired();

            modelBuilder.Entity<EntradaDeProduto>()
                .Property(entrada => entrada.ProdutoId)
                .IsRequired();

            modelBuilder.Entity<EntradaDeProduto>()
                .HasOne(entrada => entrada.Produto)
                .WithMany(produto => produto.EntradaDeProduto)
                .HasForeignKey(saida => saida.ProdutoId);

        }
    }
}