using Microsoft.EntityFrameworkCore;
using SAMP.Domain.Common;
using System.Linq.Expressions;

namespace SAMP.Persistence.Extensions
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> ApplyQueryParameters<T>(this IQueryable<T> query, QueryParameters<T> parameters)
        {
            try
            {
                if (parameters.Filters != null && parameters.Filters.Any())
                {
                    var fltrs = parameters.GetFilterFuncList();
                    if (fltrs != null)
                    {
                        query = query.FilterBy(fltrs);
                    }
                }

                if (!string.IsNullOrEmpty(parameters.SortBy))
                {
                    query = query.SortBy(parameters.SortBy, parameters.IsSortDescending ?? false);
                }

                if (parameters.PageNumber.HasValue && parameters.PageSize.HasValue)
                {
                    query = query.Paginate(parameters.PageNumber.Value, parameters.PageSize.Value);
                }

                return query;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static IQueryable<T> Paginate<T>(this IQueryable<T> query, int pageNumber, int pageSize)
        {
            return query.Skip((pageNumber - 1) * pageSize).Take(pageSize);
        }

        private static IQueryable<T> SortBy<T>(this IQueryable<T> query, string sortBy, bool isSortDescending)
        {
            if (isSortDescending)
            {
                return query.OrderByDescending(e => EF.Property<object>(e, sortBy));
            }
            else
            {
                return query.OrderBy(e => EF.Property<object>(e, sortBy));
            }
        }

        private static IQueryable<T> FilterBy<T>(this IQueryable<T> query, List<Expression<Func<T, bool>>> filters)
        {
            foreach (var filter in filters)
            {
                query = query.Where(filter);
            }
            return query;
        }
    }
}
