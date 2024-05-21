using Mapster;
using OrderShopCart.Application.CommandAndQuery;
using OrderShopCart.Dto;

namespace OrderShopCart.Server.Endpoints.Product;

public class GetProductsListMappingProfile : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.ForType<GetProductsListRequest, GetProductListQuery>();

        config.ForType<Domain.Aggregates.Product, ProductDto>()
                .Map(p => p.Id, src => src.Id.Value.ToString())
                .Map(p => p.Tags, src => src.Tags.Select(t => t.Value));
    }
}
