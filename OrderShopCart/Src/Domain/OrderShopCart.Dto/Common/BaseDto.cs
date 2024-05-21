namespace OrderShopCart.Dto;

public record BaseDto
{
    public string Id { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
