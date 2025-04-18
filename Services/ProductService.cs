using AutoMapper;
using Domain.Contracts;
using Domain.Entities;
using Services.Abstraction;
using Services.Specifications;
using Shared;
using Shared.ProductDtos;

namespace Services
{
    public class ProductService(IUnitOfWork unitOfWork, IMapper mapper) : IProductService
    {
        public async Task<IEnumerable<BrandResultDto>> GetAllBrandsAsync()
        {
            var brands = await unitOfWork.GetRepository<ProductBrand, int>().GetAllAsync();

            var mappedBrands = mapper.Map<IEnumerable<BrandResultDto>>(brands);

            return mappedBrands;
        }

        public async Task<IEnumerable<TypeResultDto>> GetAllTypesAsync()
        {
            var types = await unitOfWork.GetRepository<ProductType, int>().GetAllAsync();

            var mappedtypes = mapper.Map<IEnumerable<TypeResultDto>>(types);

            return mappedtypes;
        }

        public async Task<PaginatedResult<ProductResultDto>> GetAllProductsAsync(ProductSpecificationParams specs)
        {
            var specifications = new ProductWithFilterSpecification(specs);
            var products = await unitOfWork.GetRepository<Product, int>().GetAllAsync(specifications);

            var countSpecifications = new ProductCountSpecification(specs);
            var totalItemCount = await unitOfWork.GetRepository<Product, int>()._CountAsync(countSpecifications);

            var mappedProducts = mapper.Map<IEnumerable<ProductResultDto>>(products);

            return new PaginatedResult<ProductResultDto>(specs.PageIndex, specs.PageSize, totalItemCount, mappedProducts);
        }

        public async Task<ProductResultDto> GetProductByIdAsync(int id)
        {
            var specs = new ProductWithFilterSpecification(id);

            var product = await unitOfWork.GetRepository<Product, int>().GetAsync(specs);

            var mappedProdcut = mapper.Map<ProductResultDto>(product);

            return mappedProdcut;
        }
    }
}
