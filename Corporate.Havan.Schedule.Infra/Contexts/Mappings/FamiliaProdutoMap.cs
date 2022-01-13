using Corporate.Havan.Schedule.Domain.Entities.Produtos;
using Microsoft.EntityFrameworkCore;

namespace Corporate.Havan.Schedule.Infra.Contexts.Mappings
{
    public static class FamiliaProdutoMap
    {
        public static ModelBuilder MapFamiliaProduto(this ModelBuilder modelBuilder)
        {
            var p = modelBuilder.Entity<FamiliaProduto>();

            p.HasKey(p => p.id);
            p.Property(p => p.nome).IsRequired();

            return modelBuilder;
        }
    }
}
