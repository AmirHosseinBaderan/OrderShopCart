using Microsoft.AspNetCore.Mvc;

namespace OrderShopCart.Server.Endpoints.Group;

public record GetGroupsListRequest([FromQuery] int Page, [FromQuery] int Count);
