
using OrderShopCart.Domain;

namespace OrderShopCart.Application.CommandAndQuery;

public class GetProductQueryHandler(IBaseQuery<Product> query) : IRequestHandler<GetProductQuery, Product?>
{
    public async Task<Product?> Handle(GetProductQuery request, CancellationToken cancellationToken)
            => await query.GetAsync(EntityId.Create(request.Id));
}
