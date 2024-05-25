namespace OrderShopCart.Server.Endpoints.Product;

public record CreateProductRequest(string Title, string Description, decimal Price, IEnumerable<string> Tags);
