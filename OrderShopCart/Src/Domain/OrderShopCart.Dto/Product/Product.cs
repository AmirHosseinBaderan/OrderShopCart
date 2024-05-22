namespace OrderShopCart.Dto;

public record ProductDto : BaseDto
{
    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public IEnumerable<string> Tags { get; set; } = null!;
}

public record BuildPrdouctDto(string Title, decimal Price, string Description);