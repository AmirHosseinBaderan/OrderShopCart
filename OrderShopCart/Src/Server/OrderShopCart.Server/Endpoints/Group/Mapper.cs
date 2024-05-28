using Mapster;
using OrderShopCart.Application.CommandAndQuery;
using OrderShopCart.Dto;

namespace OrderShopCart.Server.Endpoints.Group;

public class GroupMapper : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.ForType<GetGroupsListRequest, GetGroupsListQuery>();

        config.ForType<Domain.Aggregates.Group, GroupDto>()
             .Map(p => p.Id, src => src.Id.Value.ToString());
    }
}
