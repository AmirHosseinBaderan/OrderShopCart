using LanguageExt;
using MediatR;
using OrderShopCart.Domain.Aggregates;

namespace OrderShopCart.Application.CommandAndQuery;

public record CreateProductCommand(string Title, string Description, decimal Price, IEnumerable<string> Tags) : IRequest<Either<ProductActionStatus, Product>>;
