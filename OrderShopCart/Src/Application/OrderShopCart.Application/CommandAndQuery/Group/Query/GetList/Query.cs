using OrderShopCart.Dto;

namespace OrderShopCart.Application.CommandAndQuery;

public record GetGroupsListQuery(int Page, int Count) : IRequest<BasePaginationResponse<Group>>;
