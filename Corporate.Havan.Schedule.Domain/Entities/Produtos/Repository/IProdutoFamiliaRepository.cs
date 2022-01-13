using System.Collections.Generic;
using System.Threading.Tasks;

namespace Corporate.Havan.Schedule.Domain.Entities.Produtos.Repository
{
    public interface IProdutoFamiliaRepository
    {
        Task<List<FamiliaProduto>> GetAllFalimiaProd();
    }
}
