using OrderShopCart.Builder.Abstraction;
using OrderShopCart.Dto;

namespace OrderShopCart.Builder.Implementation;

public class ProductDirector
{
    private IProductBuilder _builder = null!;

    public ProductDirector(IProductBuilder builder)
    {
        _builder = builder;
    }

    public void BuildProduct(BuildPrdouctDto product, IEnumerable<string> tags)
    {
        _builder.BuildProduct(product);
        _builder.AddTags(tags);
    }
}
