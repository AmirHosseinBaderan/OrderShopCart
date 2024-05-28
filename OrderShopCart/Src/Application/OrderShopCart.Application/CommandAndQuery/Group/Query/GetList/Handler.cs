using OrderShopCart.Application.Tools;
using OrderShopCart.Dto;

namespace OrderShopCart.Application.CommandAndQuery;

public class GetGroupsListQueryHandler(IBaseQuery<Group> query) : IRequestHandler<GetGroupsListQuery, BasePaginationResponse<Group>>
{
    public async Task<BasePaginationResponse<Group>> Handle(GetGroupsListQuery request, CancellationToken cancellationToken)
    {
        IEnumerable<Group> groups = await query.GetAllAsync(request.Page, request.Count);
        int count = await query.CountAsync();
        return groups.ToPagination(count, request.Count);
    }
}
