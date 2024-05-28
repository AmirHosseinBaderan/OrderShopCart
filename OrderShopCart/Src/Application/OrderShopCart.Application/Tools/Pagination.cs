using OrderShopCart.Dto;

namespace OrderShopCart.Application.Tools;

public static class PaginationExtensions
{
    public static BasePaginationResponse<TModel> ToPagination<TModel>(this IEnumerable<TModel> items, int itemsCount, int pageSize)
        => new(items,
            itemsCount.ToPageCount(pageSize),
            itemsCount);

    public static int ToPageCount(this int itemsCount, int pageSize)
    {
        if (itemsCount is 0 || pageSize is 0) return itemsCount;
        var pageCount = itemsCount / pageSize;
        if (itemsCount % pageSize != 0)
            pageCount++;
        return pageCount;
    }
}
