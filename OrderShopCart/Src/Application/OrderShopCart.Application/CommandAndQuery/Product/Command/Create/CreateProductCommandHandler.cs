using OrderShopCart.Builder.Implementation;

namespace OrderShopCart.Application.CommandAndQuery;

public class CreateProductCommandHandler(IBaseCud<Product> cud) : IRequestHandler<CreateProductCommand, Either<ProductActionStatus, Product>>
{
    public async Task<Either<ProductActionStatus, Product>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        ProductBuilder builder = new();
        ProductDirector director = new(builder);

        director.BuildProduct(new(request.Title, request.Price, request.Description), request.Tags);
        Product product = builder.GetProduct();

        return await cud.InsertAsync(product) ?
                product : ProductActionStatus.Failed;
    }
}
