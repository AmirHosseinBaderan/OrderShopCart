namespace OrderShopCart.Server.Abstraction;

public record ApiModel(int Code, bool Status, string Message, object? Result);

public static class ApiResponse
{
    public static string Lang { get; set; } = "fa-ir";

    public static ApiModel Success(string message, object? result)
        => new(200, true, message, result);

    public static ApiModel ApiException(string message = "خطایی رخ داد مجدادا تلاش کنید")
            => new(500, false, message, new { });

    public static ApiModel Faild(int code, string message)
        => new(code, false, message, new { });
}

public record PaginationAndLocation(int Page, int Count, string Q = "", double Lat = 0, double Lon = 0);

public record PaginationResult<TResult>(int PageCount, int ItemsCount, IEnumerable<TResult> Result);

public record CacheDuration(int Milliseconds = 0, int Second = 0, int Minute = 0, int Hour = 0, int Day = 0);
