using Microsoft.EntityFrameworkCore;

namespace MrktProduto.Repository.Context
{
    public class MrktProdutoContext : DbContext
    {

        public MrktProdutoContext(DbContextOptions<MrktProdutoContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MrktProdutoContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
