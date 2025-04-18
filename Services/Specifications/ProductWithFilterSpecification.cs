using Domain.Contracts;
using Domain.Entities;
using Shared.ProductDtos;

namespace Services.Specifications
{
    public class ProductWithFilterSpecification : Specification<Product>
    {
        public ProductWithFilterSpecification(int id) : base(product => product.Id == id) // For 1 product.
        {
            AddInclude(product => product.ProductBrand);
            AddInclude(product => product.ProductType);
        }

        public ProductWithFilterSpecification(ProductSpecificationParams specs) // client may submit the BrandId or not -> same for TypeId
            : base(product => (!specs.BrandId.HasValue || product.BrandId == specs.BrandId) && 
                                (!specs.TypeId.HasValue || product.TypeId == specs.TypeId) &&
                                (string.IsNullOrWhiteSpace(specs.Search) || product.Name.ToLower().Contains(specs.Search.ToLower().Trim())))
        {
            AddInclude(product => product.ProductBrand);
            AddInclude(product => product.ProductType);

            ApplyPagination(specs.PageIndex, specs.PageSize);

            if(specs.Sorting is not null)
            {
                switch (specs.Sorting)
                {
                    case SortingOptions.NameAsc:
                        SetOrderBy(product => product.Name);
                        break;
                    case SortingOptions.NameDesc:
                        SetOrderByDescending(product => product.Name);
                        break;
                    case SortingOptions.PriceAsc:
                        SetOrderBy(product => product.Price);
                        break;
                    case SortingOptions.PriceDesc:
                        SetOrderByDescending(product => product.Price);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
