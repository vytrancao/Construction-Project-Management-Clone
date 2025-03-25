namespace Cpm.Common.Query.Models;

using Enums;

public record SortCriterion(
    string PropertyPath,
    SortOrder Order
);