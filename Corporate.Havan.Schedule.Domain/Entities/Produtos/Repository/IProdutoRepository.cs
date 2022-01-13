using System.Threading.Tasks;

namespace Corporate.Havan.Schedule.Domain.Entities.Produtos.Repository
{
    public interface IProdutoRepository
    {
        Task<Produto> GetBayId(int idFamilia);
    }
}
