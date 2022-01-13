using Corporate.Havan.Schedule.Domain.Entities.Produtos;
using Corporate.Havan.Schedule.Domain.Entities.Produtos.Repository;
using Corporate.Havan.Schedule.Infra.Contexts;
using Corporate.Havan.Schedule.Infra.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Corporate.Havan.Schedule.Infra.Repositories
{
    public class ProdutoFamiliaRepository : GenericRepository<FamiliaProduto>, IProdutoFamiliaRepository
    {
        public ProdutoFamiliaRepository(HavanDbContext context) : base(context)
        {
        }

        public async Task<List<FamiliaProduto>> GetAllFalimiaProd()
        {
            try
            {
                return  await  _context.familiaproduto.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
