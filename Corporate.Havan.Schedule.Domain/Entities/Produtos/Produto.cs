using Corporate.Havan.Schedule.Domain.Base;

namespace Corporate.Havan.Schedule.Domain.Entities.Produtos
{
    public class Produto : Entity
    {     
        public decimal Preco { get; set; }
        public string Sku { get; set; }
        public string Nome { get; set; }
        public string UrlImagem { get; set; }
        public int IdFamilia { get; set; }
        public virtual FamiliaProduto familiaproduto { get; set; }
    }
}
