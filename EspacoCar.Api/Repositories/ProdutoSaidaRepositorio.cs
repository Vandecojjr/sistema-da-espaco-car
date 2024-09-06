using EspacoCar.Api.Data;
using EspacoCar.Api.Models.ProdutoModels;
using EspacoCar.Api.Repositories.Contratos;
using Microsoft.EntityFrameworkCore;

namespace EspacoCar.Api.Repositories
{
    public class ProdutoSaidaRepositorio : Repositorio, IProdutoSaidaRepositorio
    {
        public ProdutoSaidaRepositorio(DataContext context) : base(context)
        {
        }

        public void Cadastrar(SaidaDeProduto saida)
        {
            _context.Add(saida);
            _context.SaveChanges();
        }

        public SaidaDeProduto BuscarPorId(Guid id)
        {
            return _context.SaidaDeProdutos.Where(x => x.Id == id).First();
        }

        public ICollection<SaidaDeProduto> BuscarTodos()
        {
            return _context.SaidaDeProdutos.AsNoTracking().ToList();
        }

        public void Atualizar(SaidaDeProduto saida)
        {
            _context.Entry(saida).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            _context.SaidaDeProdutos.Remove(BuscarPorId(id));
            _context.SaveChanges();
        }
    }
}