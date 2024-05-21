using Microsoft.AspNetCore.Mvc;

namespace OrderShopCart.Server.Endpoints.Product;

public record GetProductsListRequest([FromQuery] int Page, [FromQuery] int Count);
