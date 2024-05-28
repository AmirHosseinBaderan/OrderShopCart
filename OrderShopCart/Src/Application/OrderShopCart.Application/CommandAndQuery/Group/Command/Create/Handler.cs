
namespace OrderShopCart.Application.CommandAndQuery;

public class CreateGroupCommandHandler(IBaseCud<Group> cud) : IRequestHandler<CreateGroupCommand, Group>
{
    public Task<Group> Handle(CreateGroupCommand request, CancellationToken cancellationToken)
    {

    }
}
