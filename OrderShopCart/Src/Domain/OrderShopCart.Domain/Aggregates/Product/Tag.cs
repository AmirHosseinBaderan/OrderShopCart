
namespace OrderShopCart.Domain.Aggregates;

public class Tag : ValueObject<Tag>
{
    public string Value { get; set; } = null!:


    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static Tag Create(string tagValue)
        => new()
        {
            Value = tagValue,
        };

    public override string ToString()
        => Value;
}
