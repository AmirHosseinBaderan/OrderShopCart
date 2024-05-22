namespace OrderShopCart.Server.Abstraction;

public interface IEndpointHandler<TRequest>
{
    Task<ApiModel> HandlerAsync(TRequest request, IMediator mediator, IMapper mapper);
}
