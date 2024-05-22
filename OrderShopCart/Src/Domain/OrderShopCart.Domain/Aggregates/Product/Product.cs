namespace OrderShopCart.Domain.Aggregates;

public class Product : AggregateRootBase
{

    public Product()
    {
        _tags = [];
    }

    private readonly IEnumerable<Tag> _tags = null!;


    public List<Tag> Tags => _tags.ToList();

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Price { get; set; }


}
