using EspacoCar.Api.Data;

namespace EspacoCar.Api.Repositories
{
    public class Repositorio
    {
        protected readonly DataContext _context;

        public Repositorio(DataContext context)
        {
            _context = context;
        }
    }
}