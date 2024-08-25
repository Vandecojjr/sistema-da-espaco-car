using EspacoCar.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace EspacoCar.Api.Data
{
    public partial class DataContext
    {
        public void ConfigurarProdutos(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .HasKey(produto => produto.Id);

            modelBuilder.Entity<Produto>()
                .HasIndex(produto => produto.Numero)
                .IsUnique();

            modelBuilder.Entity<Produto>()
                .Property(produto => produto.Nome)
                .HasMaxLength(50)
                .HasColumnType("varchar(50)")
                .IsRequired();

            modelBuilder.Entity<Produto>()
                .Property(produto => produto.Custo)
                .HasPrecision(10, 2)
                .IsRequired();

            modelBuilder.Entity<Produto>()
                .Property(produto => produto.Preco)
                .HasPrecision(10, 2)
                .IsRequired();

            modelBuilder.Entity<Produto>()
                .Property(produto => produto.Estoque)
                .IsRequired();

            modelBuilder.Entity<Produto>()
                .Property(produto => produto.CategoriaId)
                .IsRequired();

            modelBuilder.Entity<Produto>()
                .HasOne(produto => produto.Categoria)
                .WithMany(categoria => categoria.Produtos)
                .HasForeignKey(produto => produto.CategoriaId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Produto>()
                .HasMany(produto => produto.SaidaDeProduto)
                .WithOne(saida => saida.Produto)
                .HasForeignKey(saida => saida.ProdutoId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Produto>()
                .HasMany(produto => produto.EntradaDeProduto)
                .WithOne(entrada => entrada.Produto)
                .HasForeignKey(entrada => entrada.ProdutoId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}