using MediatR;
using Microsoft.Extensions.DependencyInjection;
using MrktProduto.Application.Service;

namespace MrktProduto.Application
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ConfigurationModule).Assembly);
            services.AddMediatR(typeof(ConfigurationModule).Assembly);

            services.AddScoped<IItemService, ItemService>();
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<AzureBlobStorage>();

            services.AddHttpClient();

            return services;
        }
    }
}
