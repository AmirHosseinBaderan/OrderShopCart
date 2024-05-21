namespace OrderShopCart.Dto;

public record ProductDto(string Title, string Description, IEnumerable<string> Tags) : BaseDto;
