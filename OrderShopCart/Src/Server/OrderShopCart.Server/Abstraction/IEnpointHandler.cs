using MapsterMapper;
using MediatR;

namespace OrderShopCart.Server.Abstraction;

public interface IEnpointHandler<TRequest, TResponse>
{
    Task<TResponse> HandlerAsync(TRequest request, IMediator mediator, IMapper mapper);
}
