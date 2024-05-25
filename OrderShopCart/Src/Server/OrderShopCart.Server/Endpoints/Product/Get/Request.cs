using Microsoft.AspNetCore.Mvc;

namespace OrderShopCart.Server.Endpoints.Product;

public record GetProductRequest([FromQuery] Guid Id);
