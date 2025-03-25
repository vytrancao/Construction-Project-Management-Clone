namespace Cpm.Common.Query.Extensions;

using System.Linq.Expressions;
using Cpm.Common.Query.Models;
using Enums;
using Microsoft.EntityFrameworkCore;

public static class Searching
{
    public static IQueryable<T> Paginate<T>(this IQueryable<T> query, BaseSearchModel searchModel)
    {
        return query.Skip(searchModel.PageIndex * searchModel.PageSize)
            .Take(searchModel.PageSize);
    }

    public static int CalculateTotalPage<T>(this IQueryable<T> query, BaseSearchModel searchModel)
    {
        return (int)Math.Ceiling(query.Count() / (double)searchModel.PageSize);
    }

    public static IQueryable<T> Filter<T>(this IQueryable<T> query, BaseSearchModel searchModel)
    {
        foreach (var criterion in searchModel.SearchCriteria)
        {
            query = query.FilterByProperty(criterion.PropertyPath, criterion.CompareOperator, criterion.SearchValue);
        }

        return query;
    }

    public static IQueryable<T> Sort<T>(this IQueryable<T> query, BaseSearchModel searchModel)
    {
        foreach (var criterion in searchModel.SortCriteria)
        {
            query = query.SortByProperty(criterion.PropertyPath, criterion.Order);
        }

        return query;
    }

    /// <summary>
    /// Sorts the query by the specified property path and sort order.
    /// </summary>
    /// <typeparam name="T">The type of the elements of the query.</typeparam>
    /// <param name="query">The query to sort.</param>
    /// <param name="propertyPath">The property path to sort by.</param>
    /// <param name="sortOrder">The sort order (ascending or descending).</param>
    /// <returns>The sorted query.</returns>
    public static IQueryable<T> SortByProperty<T>(this IQueryable<T> query, string propertyPath, SortOrder sortOrder)
    {
        var parameter = Expression.Parameter(typeof(T), "x");
        var property = GetPropertyExpression<T>(parameter, propertyPath);

        // Ensure the property is converted to object
        Expression convertedProperty = Expression.Convert(property, typeof(object));
        var lambda = Expression.Lambda<Func<T, object>>(convertedProperty, parameter);

        query = sortOrder switch
        {
            SortOrder.Asc => query.OrderBy(lambda),
            SortOrder.Desc => query.OrderByDescending(lambda),
            _ => query
        };

        return query;
    }


    /// <summary>
    /// Filters the query by the specified property path, compare operator, and value.
    /// </summary>
    /// <typeparam name="T">The type of the elements of the query.</typeparam>
    /// <param name="query">The query to filter.</param>
    /// <param name="propertyPath">The property path to filter by.</param>
    /// <param name="compareOperator">The compare operator to use for filtering.</param>
    /// <param name="value">The value to compare the property to.</param>
    /// <returns>The filtered query.</returns>
    public static IQueryable<T> FilterByProperty<T>(this IQueryable<T> query, string propertyPath, CompareOperator compareOperator, object value)
    {
        var parameter = Expression.Parameter(typeof(T), "x");
        var property = GetPropertyExpression<T>(parameter, propertyPath);

        // Convert 'value' to the same type as the property
        var propertyType = property.Type;
        var constant = Expression.Constant(Convert.ChangeType(value, propertyType));
        // var constant = Expression.Constant(Convert.ChangeType(value, propertyType));

        Expression operation = compareOperator switch
        {
            CompareOperator.Less => Expression.LessThan(property, constant),
            CompareOperator.LessOrEqual => Expression.LessThanOrEqual(property, constant),
            CompareOperator.Equal => Expression.Equal(property, constant),
            CompareOperator.NotEqual => Expression.NotEqual(property, constant),
            CompareOperator.GreaterOrEqual => Expression.GreaterThanOrEqual(property, constant),
            CompareOperator.Greater => Expression.GreaterThan(property, constant),
            CompareOperator.Contains => Expression.Call(property, typeof(string).GetMethod("Contains", [typeof(string)])!, constant),
            _ => throw new ArgumentOutOfRangeException(nameof(compareOperator), compareOperator, null)
        };
        var expression = Expression.Lambda<Func<T, bool>>(operation, parameter!);

        return query.Where(expression!);
    }

    /// <summary>
    /// Gets the property expression for the specified property path.
    /// </summary>
    /// <typeparam name="T">The type of the parameter.</typeparam>
    /// <param name="parameter">The parameter expression.</param>
    /// <param name="propertyPath">The property path.</param>
    /// <returns>The property expression.</returns>
    private static Expression GetPropertyExpression<T>(ParameterExpression parameter, string propertyPath)
    {
        // Traverse nested properties
        Expression property = parameter;
        foreach (var part in propertyPath.Split('.'))
        {
            property = Expression.Property(property, part);
        }

        return property;
    }
}