using OrderShopCart.Domain.Aggregates;
using OrderShopCart.Dto;

namespace OrderShopCart.Builder.Abstraction;

public interface IProductBuilder
{
    void BuildProduct(BuildPrdouctDto product);

    void AddTags(IEnumerable<string> tags);

    Product GetProduct();
}
