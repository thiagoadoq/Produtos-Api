using Corporate.Havan.Schedule.Domain.Contracts.Repositories.Base;
using Corporate.Havan.Schedule.Domain.Entities.Produtos.Repository;
using Corporate.Havan.Schedule.Infra.Contexts;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Threading.Tasks;

namespace Corporate.Havan.Schedule.Infra.Repositories.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HavanDbContext _context;     
        public IProdutoRepository Produtos { get; }      
        public IProdutoFamiliaRepository ProdutoFamilias { get; }      

        private bool _disposed;

        public UnitOfWork(HavanDbContext context,IProdutoRepository Produto, IProdutoFamiliaRepository produtoFamilia)
        {
            _context = context;

            Produtos = Produto;
            ProdutoFamilias = produtoFamilia;

        }

        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return await _context.Database.BeginTransactionAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        protected void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
