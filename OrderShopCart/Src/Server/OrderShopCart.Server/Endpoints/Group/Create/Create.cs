

using Microsoft.AspNetCore.Mvc;
using OrderShopCart.Server.Filters;

namespace OrderShopCart.Server.Endpoints.Group;

public class CreateGroupEndpoint : IEndpoint, IEndpointHandler<CreateGroupRequest>
{
    public Task<ApiModel> HandlerAsync(CreateGroupRequest request, IMediator mediator, IMapper mapper)
    {

    }

    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPost("/group/create", async ([FromBody] CreateGroupRequest request,
            IMediator mediator,
            IMapper mapper)
                => await HandlerAsync(request,
                mediator,
                mapper))
            .Validator<CreateGroupValidator>()
            .WithTags(EndpointSchema.GroupsTag);
    }
}
