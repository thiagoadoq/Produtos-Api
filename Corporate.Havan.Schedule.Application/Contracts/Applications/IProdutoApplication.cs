using Corporate.Havan.Schedule.Application.Mapping.Dto;
using System.Threading.Tasks;

namespace Corporate.Havan.Schedule.Application.Contracts.Applications
{
    public interface IProdutoApplication
    {
        ProdutoDto GetById(int idFamilia);        
    }
}
