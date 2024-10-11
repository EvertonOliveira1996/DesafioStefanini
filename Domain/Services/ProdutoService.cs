using Domain.Entities;
using Domain.Interfaces;
namespace Domain.Services
{
    public class ProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository ?? throw new ArgumentNullException(nameof(produtoRepository)); ;
        }

        public async Task<IEnumerable<Produto>> ListarProdutosAsync()
        {
            return await _produtoRepository.ListarTodosAsync();
        }
    }
}
