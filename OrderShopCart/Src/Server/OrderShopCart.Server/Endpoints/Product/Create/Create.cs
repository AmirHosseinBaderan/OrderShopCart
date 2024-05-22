

using Microsoft.AspNetCore.Mvc;

namespace OrderShopCart.Server.Endpoints.Product;

public class CreateProductEndpoint : IEndpoint, IEndpointHandler<CreateProductRequest>
{
    public Task<ApiModel> HandlerAsync(CreateProductRequest request, IMediator mediator, IMapper mapper)
    {

    }

    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("/product/create",
               async ([FromBody] CreateProductRequest request,
               IMapper mapper,
               IMediator mediator) =>
                   await HandlerAsync(request,
                   mediator,
                   mapper)
               ).WithTags(EndpointSchema.ProductsTag);
    }
}
