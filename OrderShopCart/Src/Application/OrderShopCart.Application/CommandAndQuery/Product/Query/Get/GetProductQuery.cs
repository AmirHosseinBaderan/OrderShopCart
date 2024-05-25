namespace OrderShopCart.Application.CommandAndQuery;

public record GetProductQuery(Guid Id) : IRequest<Product?>;
