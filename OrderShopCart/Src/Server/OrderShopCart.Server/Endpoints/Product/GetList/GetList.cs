

namespace OrderShopCart.Server.Endpoints.Product;

public class GetList : IEndpoint, IEnpointHandler<GetProductsListRequest, GetProductsListResponse>
{
    public Task<GetProductsListResponse> HandlerAsync(GetProductsListRequest request, IMediator mediator, IMapper mapper)
    {
        throw new NotImplementedException();
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
