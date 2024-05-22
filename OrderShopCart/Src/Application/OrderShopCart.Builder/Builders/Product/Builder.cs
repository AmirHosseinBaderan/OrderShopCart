namespace OrderShopCart.Builder;

public class ProductBuilder
{
    private readonly Product _product = new();

    public ProductBuilder Create(string title, string description, decimal price, IEnumerable<string> tags)
         => CreateDraft(title, description, price)
                .AddTags(tags);

    public ProductBuilder CreateDraft(string title, string description, decimal price)
    {
        _product.Title = title;
        _product.Description = description;
        _product.Price = price;

        return this;
    }

    public ProductBuilder AddTags(IEnumerable<string> tags)
    {
        _product.Tags.AddRange(tags.Select(Tag.Create));
        return this;
    }

    public Product Export() => _product;
}
