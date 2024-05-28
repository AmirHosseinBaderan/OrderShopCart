

using OrderShopCart.Application.CommandAndQuery;
using OrderShopCart.Dto;

namespace OrderShopCart.Server.Endpoints.Group;

public class GetGroupsListEndpoint : IEndpoint, IEndpointHandler<GetGroupsListRequest>
{
    public async Task<ApiModel> HandlerAsync(GetGroupsListRequest request, IMediator mediator, IMapper mapper)
    {
        GetGroupsListQuery command = mapper.Map<GetGroupsListQuery>(request);
        var result = await mediator.Send(command);
        return Success("", new
        {
            Groups = mapper.Map<GroupDto>(result.Result),
            result.PagesCount,
            result.TotalItemsCount,
        });
    }

    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("/group/getlist", async
                ([AsParameters] GetGroupsListRequest request,
                IMediator mediator,
                IMapper mapper)
                => await HandlerAsync(request,
                mediator,
                mapper))
            .WithTags(EndpointSchema.GroupsTag);
    }
}
