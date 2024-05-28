namespace OrderShopCart.Application.CommandAndQuery;

public record CreateGroupCommand(string Title, string Name) : IRequest<Group>;
