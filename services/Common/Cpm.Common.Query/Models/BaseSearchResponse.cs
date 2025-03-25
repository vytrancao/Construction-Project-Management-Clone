namespace Cpm.Common.Query.Models;

public record BaseSearchResponse<T>(
    int PageIndex,
    int PageSize,
    int TotalPage,
    IEnumerable<T> Items
)
{
    public BaseSearchResponse() : this(0, 0, 0, Array.Empty<T>())
    {
    }
}