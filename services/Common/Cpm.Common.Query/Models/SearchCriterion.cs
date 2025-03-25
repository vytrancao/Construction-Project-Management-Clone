namespace Cpm.Common.Query.Models;

using Enums;

public record SearchCriterion(
    string PropertyPath,
    string SearchValue,
    CompareOperator CompareOperator
);