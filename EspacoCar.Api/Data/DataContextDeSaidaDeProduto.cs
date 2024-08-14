using EspacoCar.Api.Models.ProdutoModels;
using Microsoft.EntityFrameworkCore;

namespace EspacoCar.Api.Data
{
    public partial class DataContext
    {
        public void ConfigurarSaidaDeProduto(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SaidaDeProduto>()
                .HasKey(saida => saida.Id);

            modelBuilder.Entity<SaidaDeProduto>()
                .Property(saida => saida.Quantidade)
                .IsRequired();

            modelBuilder.Entity<SaidaDeProduto>()
                .Property(saida => saida.Data)
                .IsRequired();

            modelBuilder.Entity<SaidaDeProduto>()
                .Property(saida => saida.ProdutoId)
                .IsRequired();

            modelBuilder.Entity<SaidaDeProduto>()
                .HasOne(saida => saida.Produto)
                .WithMany(produto => produto.SaidaDeProduto)
                .HasForeignKey(saida => saida.ProdutoId);

        }
    }
}