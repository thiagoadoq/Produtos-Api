using Corporate.Havan.Schedule.Domain.Entities.Produtos;
using Corporate.Havan.Schedule.Infra.Contexts.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Corporate.Havan.Schedule.Infra.Contexts
{
    public class HavanDbContext : DbContext
    {
        public DbSet<Produto> produto { get; set; } 
        public DbSet<FamiliaProduto> familiaproduto { get; set; } 
        
        public HavanDbContext(DbContextOptions<HavanDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.MapProduto();         
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
