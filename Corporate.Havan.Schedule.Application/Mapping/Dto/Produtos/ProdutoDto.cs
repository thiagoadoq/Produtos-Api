using Corporate.Havan.Schedule.Domain.Entities.Produtos;

namespace Corporate.Havan.Schedule.Application.Mapping.Dto
{
    public class ProdutoDto
    {
        public decimal Preco { get; set; }
        public string Sku { get; set; }
        public string Nome { get; set; }
        public string UrlImagem { get; set; }
        public int IdFamilia { get; set; }
        public virtual FamiliaProduto FamiliaProduto { get; set; }
    }
}
