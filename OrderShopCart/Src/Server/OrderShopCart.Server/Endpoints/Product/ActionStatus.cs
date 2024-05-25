using OrderShopCart.Application.CommandAndQuery;

namespace OrderShopCart.Server.Endpoints;

public static class ProductsActionResult
{
    public static ApiModel ToApiResult(this ProductActionStatus status)
            => status switch
            {
                ProductActionStatus.Success => Success("عملیات با موفقیت انجام شد", new { }),
                ProductActionStatus.Failed => ApiException(),
                ProductActionStatus.NotFound => Faild(404, "موردی یافت نشد"),
                _ => ApiException(),
            };
}