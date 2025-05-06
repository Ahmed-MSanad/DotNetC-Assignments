using AutoMapper;
using Domain.Entities.OrderEntities;
using Shared.OrderDtos;


namespace Services.MappingProfiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile() {
            CreateMap<Address, Shared.OrderDtos.AddressDto>().ReverseMap();

            CreateMap<OrderItem, OrderItemDto>()
                .ForMember(dest => dest.ProductId, options => options.MapFrom(src => src.product.ProductId))
                .ForMember(dest => dest.ProductName, options => options.MapFrom(src => src.product.ProductName))
                .ForMember(dest => dest.PictureUrl, options => options.MapFrom(src => src.product.PictureUrl));

            CreateMap<Order, OrderResult>()
                .ForMember(dest => dest.PaymentStatus, options => options.MapFrom(src => src.PaymentStatus.ToString()))
                .ForMember(dest => dest.DeliveryMethod, options => options.MapFrom(src => src.DeliveryMethod.ShortName))
                .ForMember(dest => dest.Total, options => options.MapFrom(src => src.SubTotal + src.DeliveryMethod.Price));

            CreateMap<DeliveryMethod, DeliveryMethodResult>();
        }
    }
}
