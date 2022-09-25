using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MrktProduto.Domain.Repository;
using MrktProduto.Repository.Context;
using MrktProduto.Repository.Database;
using MrktProduto.Repository.Repository;

namespace MrktProduto.Repository
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterRepository(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<MrktProdutoContext>(c =>
            {
                c.UseSqlServer(connectionString);
            });

            services.AddScoped(typeof(Repository<>));
            services.AddScoped<IItemRepository, ItemRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();

            return services;
        }
    }
}