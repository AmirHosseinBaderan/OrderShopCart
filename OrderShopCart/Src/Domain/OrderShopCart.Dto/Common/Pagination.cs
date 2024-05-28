namespace OrderShopCart.Dto;

public record BasePaginationResponse<TResult>(IEnumerable<TResult> Result, int PagesCount, int TotalItemsCount);
