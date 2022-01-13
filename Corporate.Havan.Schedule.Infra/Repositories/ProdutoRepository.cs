using Corporate.Havan.Schedule.Domain.Entities.Produtos;
using Corporate.Havan.Schedule.Domain.Entities.Produtos.Repository;
using Corporate.Havan.Schedule.Infra.Contexts;
using Corporate.Havan.Schedule.Infra.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Corporate.Havan.Schedule.Infra.Repositories
{
    public class ProdutoRepository : GenericRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(HavanDbContext context) : base(context)
        {
        }

        public async Task<Produto> GetBayId(int idFamilia)
        {
            try
            {
                return await _context.produto.Include(c => c.familiaproduto).Where(c => c.IdFamilia == idFamilia).FirstOrDefaultAsync();
            }
            catch (Exception)
            {
                throw;
            }           
        }
    }
}
