namespace OrderShopCart.Dto;

public record GroupDto : BaseDto
{
    public string Name { get; set; } = null!;

    public string Title { get; set; } = null!;
}
