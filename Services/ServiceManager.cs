using AutoMapper;
using Domain.Contracts;
using Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
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
                                IOptions<JwtOptions> options)
        {
            _productService = new Lazy<IProductService>(() => new ProductService(unitOfWork, mapper));
            _basketService = new Lazy<IBasketService>(() => new BasketService(basketRepository, mapper));
            _authenticationService = new Lazy<IAuthenticationService>(() => new AuthenticationService(userManager, mapper, options));
        }

        private readonly Lazy<IProductService> _productService;
        public IProductService ProductService => _productService.Value;


        private readonly Lazy<IBasketService> _basketService;
        public IBasketService BasketService => _basketService.Value;


        private readonly Lazy<IAuthenticationService> _authenticationService;
        public IAuthenticationService AuthenticationService => _authenticationService.Value;
    }
}
