using EspacoCar.Api.Models;
using EspacoCar.Api.Models.ProdutoModels;
using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;

namespace EspacoCar.Api.Data
{
    public partial class DataContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<CategoriaDeProduto> Categorias { get; set; }
        public DbSet<SaidaDeProduto> SaidaDeProdutos { get; set; }
        public DbSet<EntradaDeProduto> EntradaDeProdutos { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Notification>();
            ConfigurarProdutos(modelBuilder);
            ConfigurarCategorias(modelBuilder);
            ConfigurarSaidaDeProduto(modelBuilder);
            ConfigurarEntradaDeProduto(modelBuilder);
        }
    }
}