using Microsoft.AspNetCore.Mvc;
using Services.Abstraction;
using Shared;
using Shared.ProductDtos;

namespace Presentation.Controllers
{
    public class ProductController(IServiceManager serviceManager) : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<PaginatedResult<ProductResultDto>>> GetAllProducts([FromQuery] ProductSpecificationParams specs)
        {
            var products = await serviceManager.ProductService.GetAllProductsAsync(specs);

            return Ok(products);
        }

        [HttpGet]
        public async Task<ActionResult<ProductResultDto>> GetProduct(int id)
        {
            var product = await serviceManager.ProductService.GetProductByIdAsync(id);

            return Ok(product);
        }

        [HttpGet]
        public async Task<ActionResult<BrandResultDto>> GetAllBrands()
        {
            var brands = await serviceManager.ProductService.GetAllBrandsAsync();

            return Ok(brands);
        }

        [HttpGet]
        public async Task<ActionResult<TypeResultDto>> GetAllTypes()
        {
            var types = await serviceManager.ProductService.GetAllTypesAsync();

            return Ok(types);
        }
    }
}
