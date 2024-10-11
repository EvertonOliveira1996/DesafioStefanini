using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Repository.tests
{
    public class InMemoryDatabaseTests
    {
        private readonly ApplicationDbContext _context;

        public InMemoryDatabaseTests()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDb")
                .Options;

            _context = new ApplicationDbContext(options);
        }

        [Fact]
        public async Task CanAddAndRetrieveProduto()
        {
            // Criar um novo produto
            var produto = new Produto { NomeProduto = "Produto Teste", Valor = 10 };
            await _context.Produtos.AddAsync(produto);
            await _context.SaveChangesAsync();

            // Verificar se o produto foi adicionado
            var produtos = await _context.Produtos.ToListAsync();
            Assert.Single(produtos);
            Assert.Equal("Produto Teste", produtos.First().NomeProduto);
        }

        [Fact]
        public async Task CanUpdateProduto()
        {
            // Adicionar um produto
            var produto = new Produto { NomeProduto = "Produto Teste", Valor = 10 };
            await _context.Produtos.AddAsync(produto);
            await _context.SaveChangesAsync();

            // Atualizar o produto
            produto.NomeProduto = "Produto Atualizado";
            _context.Produtos.Update(produto);
            await _context.SaveChangesAsync();

            // Verificar se o produto foi atualizado
            var atualizado = await _context.Produtos.FirstAsync();
            Assert.Equal("Produto Atualizado", atualizado.NomeProduto);
        }

        [Fact]
        public async Task CanDeleteProduto()
        {
            // Adicionar um produto
            var produto = new Produto { NomeProduto = "Produto Teste", Valor = 10 };
            await _context.Produtos.AddAsync(produto);
            await _context.SaveChangesAsync();

            // Deletar o produto
            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();

            // Verificar se o produto foi deletado
            var produtos = await _context.Produtos.ToListAsync();
            Assert.Empty(produtos);
        }
    }
}
