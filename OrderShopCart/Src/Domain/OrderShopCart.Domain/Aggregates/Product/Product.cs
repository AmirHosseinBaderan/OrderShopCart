namespace OrderShopCart.Domain.Aggregates;

public class Product : AggregateRootBase
{

    public Product()
    {
        _tags = [];
        _groups = [];
    }

    private readonly List<Tag> _tags = null!;

    private readonly List<Group> _groups = null!;

    public IReadOnlyList<Tag> Tags => _tags;

    public IReadOnlyList<Group> Groups => _groups;

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Price { get; set; }

    public void AddTag(Tag tag)
        => _tags.Add(tag);

    public void AddTagRange(IEnumerable<Tag> tag)
       => _tags.AddRange(tag);

    public void AddGroup(Group group)
        => _groups.Add(group);

    public void AddGroupRange(IEnumerable<Group> group)
        => _groups.AddRange(group);
}
