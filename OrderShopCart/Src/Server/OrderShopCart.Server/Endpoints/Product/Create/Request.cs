namespace OrderShopCart.Server.Endpoints.Product;

public record CreateProductRequest(string Title, string Description, IEnumerable<string> Tags);
