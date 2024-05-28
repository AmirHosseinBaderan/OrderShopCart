namespace OrderShopCart.Domain.Aggregates;

public class Group : AggregateRootBase
{
    public string Name { get; set; } = null!;

    public string Title { get; set; } = null!;
}
