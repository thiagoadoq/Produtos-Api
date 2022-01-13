using Corporate.Havan.Schedule.Domain.Entities.Produtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Corporate.Havan.Schedule.Application.Contracts.Applications
{
    public interface IProdutoFamiliaApplication
    {    
        Task<List<FamiliaProduto>> GetAllFamiliaProd();  
    }
}
