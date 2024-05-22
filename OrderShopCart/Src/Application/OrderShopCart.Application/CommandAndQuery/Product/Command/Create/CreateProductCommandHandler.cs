using OrderShopCart.Builder;

namespace OrderShopCart.Application.CommandAndQuery;

public class CreateProductCommandHandler(IBaseCud<Product> cud) : IRequestHandler<CreateProductCommand, Either<ProductActionStatus, Product>>
{
    public async Task<Either<ProductActionStatus, Product>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        Product product = new ProductBuilder()
                        .Create(request.Title,
                                request.Description,
                                request.Price,
                                request.Tags)
                        .Export();

        return await cud.InsertAsync(product) ?
                product : ProductActionStatus.Failed;
    }
}
