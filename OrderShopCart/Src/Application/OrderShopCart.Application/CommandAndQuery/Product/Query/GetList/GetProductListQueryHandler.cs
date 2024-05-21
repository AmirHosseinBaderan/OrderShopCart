using MediatR;
using OrderShopCart.Domain.Aggregates;
using OrderShopCart.Domain.Common;

namespace OrderShopCart.Application.CommandAndQuery;

public class GetProductListQueryHandler(IBaseQuery<Product> query) : IRequestHandler<GetProductListQuery, IEnumerable<Product>>
{
    public async Task<IEnumerable<Product>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
        => await query.GetAllAsync(request.Page, request.Count);
}
