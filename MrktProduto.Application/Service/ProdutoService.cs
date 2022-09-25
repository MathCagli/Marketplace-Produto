using AutoMapper;
using MrktProduto.Application.DTO;
using MrktProduto.Domain.Models;
using MrktProduto.Domain.Repository;

namespace MrktProduto.Application.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository produtoRepository;
        private readonly IMapper mapper;
        private readonly IHttpClientFactory httpClientFactory;
        private readonly AzureBlobStorage storage;

        public ProdutoService(IProdutoRepository produtoRepository, IMapper mapper, IHttpClientFactory httpClientFactory, AzureBlobStorage storage)
        {
            this.produtoRepository = produtoRepository;
            this.mapper = mapper;
            this.httpClientFactory = httpClientFactory;
            this.storage = storage;
        }

        public async Task<ProdutoOutputDto> Criar(ProdutoInputDto dto)
        {
            var Produto = this.mapper.Map<Produto>(dto);
            HttpClient httpClient = this.httpClientFactory.CreateClient();
            using var response = await httpClient.GetAsync(dto.Imagem);
            if (response.IsSuccessStatusCode)
            {
                using var stream = await response.Content.ReadAsStreamAsync();
                var fileName = $"{Guid.NewGuid()}.jpg";
                var pathStorage = await this.storage.UploadFile(fileName, stream);
                Produto.Imagem = pathStorage;
            }
            await this.produtoRepository.Save(Produto);
            return this.mapper.Map<ProdutoOutputDto>(Produto);
        }

        public async Task<List<ProdutoOutputDto>> ListarTodos()
        {
            var Produto = await this.produtoRepository.GetAll();
            return this.mapper.Map<List<ProdutoOutputDto>>(Produto);
        }

        public async Task<ProdutoOutputDto> BuscarPorID(string id)
        {
            var Produto = await this.produtoRepository.Get(id);
            return this.mapper.Map<ProdutoOutputDto>(Produto);
        }

        public async Task<ProdutoOutputDto> Atualizar(ProdutoOutputDto dto)
        {
            var Produto = this.mapper.Map<Produto>(dto);
            await this.produtoRepository.Update(Produto);
            return this.mapper.Map<ProdutoOutputDto>(Produto);
        }

        public async Task<string> Remover(string id)
        {
            var Produto = await this.produtoRepository.Get(id);
            await this.produtoRepository.Delete(Produto);
            return id;
        }
    }
}