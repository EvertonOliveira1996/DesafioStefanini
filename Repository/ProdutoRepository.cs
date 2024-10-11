using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Domain.Interfaces;

namespace Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationDbContext _context;

        public ProdutoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Produto>> ListarTodosAsync()
        {
            return await _context.Produtos.ToListAsync();
        }
    }
}
