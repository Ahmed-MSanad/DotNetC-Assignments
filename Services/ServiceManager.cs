using AutoMapper;
using Domain.Contracts;
using Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Services.Abstraction;
using Shared.IdentityDtos;

namespace Services
{
    public sealed class ServiceManager : IServiceManager
    {
        public ServiceManager(IUnitOfWork unitOfWork, IMapper mapper, 
                                IBasketRepository basketRepository, 
                                UserManager<User> userManager,
                                IOptions<JwtOptions> options,
                                IConfiguration configuration,
                                ICacheRepository cacheRepository)
        {
            _productService = new Lazy<IProductService>(() => new ProductService(unitOfWork, mapper));
            _basketService = new Lazy<IBasketService>(() => new BasketService(basketRepository, mapper));
            _authenticationService = new Lazy<IAuthenticationService>(() => new AuthenticationService(userManager, mapper, options));
            _orderService = new Lazy<IOrderService>(() => new OrderService(unitOfWork, mapper, basketRepository));
            _paymentService = new Lazy<IPaymentService>(() => new PaymentService(unitOfWork, basketRepository, mapper, configuration));
            _cacheService = new Lazy<ICacheService>(() => new CacheService(cacheRepository));
        }

        private readonly Lazy<IProductService> _productService;
        public IProductService ProductService => _productService.Value;


        private readonly Lazy<IBasketService> _basketService;
        public IBasketService BasketService => _basketService.Value;


        private readonly Lazy<IAuthenticationService> _authenticationService;
        public IAuthenticationService AuthenticationService => _authenticationService.Value;


        private readonly Lazy<IOrderService> _orderService;
        public IOrderService OrderService => _orderService.Value;

        private readonly Lazy<IPaymentService> _paymentService;
        public IPaymentService paymentService => _paymentService.Value;


        private readonly Lazy<ICacheService> _cacheService;
        public ICacheService cacheService => _cacheService.Value;
    }
}
