namespace OrderShopCart.Domain.Aggregates;

public class Group : AggregateRootBase
{
    public Group()
    {
        _products = [];
    }

    private readonly List<Product> _products = null!;

    public IReadOnlyList<Product> Products => _products;

    public string Name { get; set; } = null!;

    public string Title { get; set; } = null!;

    public void AddProduct(Product product)
        => _products.Add(product);

    public void AddProductRange(IEnumerable<Product> products)
        => _products.AddRange(products);
}
