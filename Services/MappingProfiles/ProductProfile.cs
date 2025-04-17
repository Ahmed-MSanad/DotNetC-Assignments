using AutoMapper;
using Domain.Entities;
using Shared;

namespace Services.MappingProfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductResultDto>()
                .ForMember(productResultDto => productResultDto.BrandName, options => options.MapFrom(product => product.ProductBrand.Name))
                .ForMember(productResultDto => productResultDto.TypeName, options => options.MapFrom(product => product.ProductType.Name))
                .ForMember(productResultDto => productResultDto.PictureUrl, options => options.MapFrom<PictureUrlResolver>());

            CreateMap<ProductBrand, BrandResultDto>();

            CreateMap<ProductType, TypeResultDto>();
        }
    }
}
