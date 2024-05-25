namespace OrderShopCart.Domain.Aggregates;

public class Product : AggregateRootBase
{

    public Product()
    {
        _tags = [];
    }

    private readonly List<Tag> _tags = null!;

    public List<Tag> Tags => _tags.ToList();

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Price { get; set; }

    public void AddTag(Tag tag)
        => _tags.Add(tag);

    public void AddTagRange(IEnumerable<Tag> tag)
       => _tags.AddRange(tag);
}
