using Corporate.Havan.Schedule.Domain.Entities.Produtos;
using Microsoft.EntityFrameworkCore;

namespace Corporate.Havan.Schedule.Infra.Contexts.Mappings
{
    public static class ProdutoDbMap
    {
        public static ModelBuilder MapProduto(this ModelBuilder modelBuilder)
        {
            var p = modelBuilder.Entity<Produto>();

            p.HasKey(p => p.id);
            p.Property(p => p.IdFamilia).IsRequired().HasColumnName("idfamilia");
            p.Property(p => p.Preco).IsRequired().HasColumnName("preco");
            p.Property(p => p.Sku).HasMaxLength(60).HasColumnName("sku");  
            p.Property(p => p.Nome).HasMaxLength(320).HasColumnName("nome");  
            p.Property(p => p.UrlImagem).HasMaxLength(120).IsRequired().HasColumnName("urlimagem");

            p.HasOne(p => p.familiaproduto)
               .WithMany()
               .HasForeignKey(p => p.IdFamilia)            
               .OnDelete(DeleteBehavior.Restrict);

            return modelBuilder;
        }
    }
}
