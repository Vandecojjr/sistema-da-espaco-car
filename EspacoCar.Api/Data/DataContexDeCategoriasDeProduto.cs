using EspacoCar.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace EspacoCar.Api.Data
{
    public partial class DataContext
    {
        public void ConfigurarCategorias(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoriaDeProduto>()
                .HasKey(categoria => categoria.Id);

            modelBuilder.Entity<CategoriaDeProduto>()
                .Property(categoria => categoria.Nome)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<CategoriaDeProduto>()
                .HasMany(categoria => categoria.Produtos)
                .WithOne(produto => produto.Categoria)
                .HasForeignKey(produto => produto.CategoriaId);
        }
    }
}