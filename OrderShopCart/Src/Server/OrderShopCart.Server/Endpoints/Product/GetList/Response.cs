using OrderShopCart.Dto;

namespace OrderShopCart.Server.Endpoints.Product;

public record GetProductsListResponse(IEnumerable<ProductDto> Products);
