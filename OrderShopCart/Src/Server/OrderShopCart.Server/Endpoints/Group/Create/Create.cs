

namespace OrderShopCart.Server.Endpoints.Group;

public class CreateGroupEndpoint : IEndpoint, IEndpointHandler<CreateGroupRequest>
{
    public Task<ApiModel> HandlerAsync(CreateGroupRequest request, IMediator mediator, IMapper mapper)
    {
        throw new NotImplementedException();
    }

    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        throw new NotImplementedException();
    }
}
