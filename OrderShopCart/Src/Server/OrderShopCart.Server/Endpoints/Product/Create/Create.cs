

using Microsoft.AspNetCore.Mvc;
using OrderShopCart.Application.CommandAndQuery;
using OrderShopCart.Dto;

namespace OrderShopCart.Server.Endpoints.Product;

public class CreateProductEndpoint : IEndpoint, IEndpointHandler<CreateProductRequest>
{
    public async Task<ApiModel> HandlerAsync(CreateProductRequest request, IMediator mediator, IMapper mapper)
    {
        CreateProductCommand command = mapper.Map<CreateProductCommand>(request);
        var resutl = await mediator.Send(command);

        return resutl.Match(Left: (status) => status.ToApiResult(),
            Right: (product) => Success("", mapper.Map<ProductDto>(product)));
    }

    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPost("/product/create",
               async ([FromBody] CreateProductRequest request,
               IMapper mapper,
               IMediator mediator) =>
                   await HandlerAsync(request,
                   mediator,
                   mapper)
               ).WithTags(EndpointSchema.ProductsTag);
    }
}
