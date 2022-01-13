using Corporate.Havan.Schedule.Domain.Entities.Produtos.Repository;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Threading.Tasks;

namespace Corporate.Havan.Schedule.Domain.Contracts.Repositories.Base
{
    public interface IUnitOfWork : IDisposable
    {
        Task<IDbContextTransaction> BeginTransactionAsync();
        Task<int> SaveAsync();
            
        IProdutoRepository Produtos { get; }
        IProdutoFamiliaRepository ProdutoFamilias { get; }       
    }
}
