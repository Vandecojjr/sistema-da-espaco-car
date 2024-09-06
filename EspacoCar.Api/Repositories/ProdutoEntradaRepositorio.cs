using EspacoCar.Api.Data;
using EspacoCar.Api.Models.ProdutoModels;
using EspacoCar.Api.Repositories.Contratos;
using Microsoft.EntityFrameworkCore;

namespace EspacoCar.Api.Repositories
{
    public class ProdutoEntradaRepositorio : Repositorio, IProdutoEntradaRepositorio
    {
        public ProdutoEntradaRepositorio(DataContext context) : base(context)
        {
        }

        public void Cadastrar(EntradaDeProduto entrada)
        {
            _context.Add(entrada);
            _context.SaveChanges();
        }

        public EntradaDeProduto BuscarPorId(Guid id)
        {
            return _context.EntradaDeProdutos.Where(x => x.Id == id).First();
        }

        public ICollection<EntradaDeProduto> BuscarTodos()
        {
            return _context.EntradaDeProdutos.AsNoTracking().ToList();
        }

        public void Atualizar(EntradaDeProduto entrada)
        {
            _context.Entry(entrada).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            _context.EntradaDeProdutos.Remove(BuscarPorId(id));
            _context.SaveChanges();
        }
    }
}