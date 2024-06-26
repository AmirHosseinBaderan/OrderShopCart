﻿

using OrderShopCart.Application.CommandAndQuery;
using OrderShopCart.Dto;

namespace OrderShopCart.Server.Endpoints.Product;

public class GetList : IEndpoint, IEndpointHandler<GetProductsListRequest>
{
    public async Task<ApiModel> HandlerAsync(GetProductsListRequest request, IMediator mediator, IMapper mapper)
    {
        GetProductListQuery query = mapper.Map<GetProductListQuery>(request);
        IEnumerable<Domain.Aggregates.Product> result = await mediator.Send(query);

        IEnumerable<ProductDto> products = mapper.Map<IEnumerable<ProductDto>>(result);
        return Success("", products);
    }

    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("/product/getlist",
                async ([AsParameters] GetProductsListRequest request,
                IMapper mapper,
                IMediator mediator) =>
                    await HandlerAsync(request,
                    mediator,
                    mapper)
                ).WithTags(EndpointSchema.ProductsTag);
    }
}
