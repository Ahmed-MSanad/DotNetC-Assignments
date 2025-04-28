using AutoMapper;
using Domain.Contracts;
using Services.Abstraction;

namespace Services
{
    public sealed class ServiceManager : IServiceManager
    {
        public ServiceManager(IUnitOfWork unitOfWork, IMapper mapper, IBasketRepository basketRepository)
        {
            _productService = new Lazy<IProductService>(() => new ProductService(unitOfWork, mapper));
            _basketService = new Lazy<IBasketService>(() => new BasketService(basketRepository, mapper));
        }

        private readonly Lazy<IProductService> _productService;
        public IProductService ProductService => _productService.Value;


        private readonly Lazy<IBasketService> _basketService;
        public IBasketService BasketService => _basketService.Value;
    }
}
