

using OrderShopCart.Application.CommandAndQuery;
using OrderShopCart.Dto;

namespace OrderShopCart.Server.Endpoints.Product;

public class GetProduct : IEndpoint, IEndpointHandler<GetProductRequest>
{
    public async Task<ApiModel> HandlerAsync(GetProductRequest request, IMediator mediator, IMapper mapper)
    {
        var command = mapper.Map<GetProductQuery>(request);
        var product = await mediator.Send(command);
        return product is null ?
                Faild(404, "محصول مورد نظر یافت نشد")
                : Success("", mapper.Map<ProductDto>(product));
    }

    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("/product/get",
                async ([AsParameters] GetProductRequest request,
                IMediator mediator,
                IMapper mapper) =>
         await HandlerAsync(request,
         mediator,
         mapper))
            .WithTags(EndpointSchema.ProductsTag);
    }
}
