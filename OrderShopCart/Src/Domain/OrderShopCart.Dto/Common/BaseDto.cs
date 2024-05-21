namespace OrderShopCart.Dto;

public record BaseDto
{
    public Guid Id { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
