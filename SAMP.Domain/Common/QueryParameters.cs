
using System.Linq.Expressions;


namespace SAMP.Domain.Common;

public class QueryParameters<T>
{
    private List<FilterModel>? filters;

    public int? PageNumber { get; set; }
    public int? PageSize { get; set; }
    public string? SortBy { get; set; }
    public bool? IsSortDescending { get; set; }
    public List<FilterModel>? Filters { get => filters; set => filters = value; }
    public List<Expression<Func<T, bool>>>? GetFilterFuncList()
    {
        if (filters != null)
        {
            // Convert the filter models to expressions
            var filterExpressions = filters.Select(f => FilterConverter.ConvertToExpression<T>(f)).ToList();
            return filterExpressions;
        }
        return null;
    }
}
public static class FilterConverter
{
    public static Expression<Func<T, bool>> ConvertToExpression<T>(FilterModel filter)
    {
        var parameterExp = Expression.Parameter(typeof(T), "type");
        var propertyExp = Expression.Property(parameterExp, filter.PropertyName);
        var constantExp = Expression.Constant(Convert.ChangeType(filter.Value, propertyExp.Type));
        var comparisonExp = Expression.Equal(propertyExp, constantExp);
        return Expression.Lambda<Func<T, bool>>(comparisonExp, parameterExp);
    }
}