using MediatR;
using OrderShopCart.Domain.Aggregates;

namespace OrderShopCart.Application.CommandAndQuery;

public record GetProductListQuery(int Page, int Count) : IRequest<IEnumerable<Product>>;
