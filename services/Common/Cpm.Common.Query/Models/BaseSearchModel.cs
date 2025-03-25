namespace Cpm.Common.Query.Models;

public record BaseSearchModel(
    IEnumerable<SearchCriterion> SearchCriteria,
    IEnumerable<SortCriterion> SortCriteria,
    int PageIndex,
    int PageSize
)
{
    public BaseSearchModel() : this(Array.Empty<SearchCriterion>(), Array.Empty<SortCriterion>(), 1, 10)
    {
    }
}