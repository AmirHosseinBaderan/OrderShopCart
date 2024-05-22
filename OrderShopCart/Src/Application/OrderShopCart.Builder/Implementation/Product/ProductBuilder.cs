using OrderShopCart.Builder.Abstraction;
using OrderShopCart.Domain.Aggregates;
using OrderShopCart.Dto;

namespace OrderShopCart.Builder.Implementation;

public class ProductBuilder : IProductBuilder
{
    private Product _product = new();

    public void AddTags(IEnumerable<string> tags)
    {
        var tagsList = tags.Select(t => Tag.Create(t));
        _product.Tags.AddRange(tagsList);
    }

    public void BuildProduct(BuildPrdouctDto product)
    {
        _product = new()
        {
            CreatedOn = DateTime.Now,
            Description = product.Description,
            Price = product.Price,
            Title = product.Title,
        };
    }

    public Product GetProduct()
        => _product;
}
