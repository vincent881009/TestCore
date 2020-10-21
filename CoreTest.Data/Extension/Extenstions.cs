using CoreTest.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace CoreTest.Service.Extension
{
   public static  class Extenstions
    {
        public static PagedListLayUI<T> ToPagedListLayUI<T>(this IQueryable<T> IQueryable, int pageIndex, int pageSize)
        {
            PagedListLayUI<T> list = new PagedListLayUI<T>(IQueryable, pageIndex, pageSize);
            return list;
        }

        public static PagedListLayUI<T> ToPagedListLayUI2<T>(this IEnumerable<T> IEnumerable, int pageIndex, int pageSize)
        {
            PagedListLayUI<T> list = new PagedListLayUI<T>(IEnumerable, pageIndex, pageSize, IEnumerable.Count());
            return list;
        }

        public static IQueryable<T> OrderByQueryableLayUI<T>(this IQueryable<T> source, string propertyName, bool ascending) where T : class
        {
            Type type = typeof(T);

            PropertyInfo property = type.GetProperty(propertyName);
            if (property == null)
                throw new ArgumentException("propertyName", "Not Exist");

            ParameterExpression param = Expression.Parameter(type, "p");
            Expression propertyAccessExpression = Expression.MakeMemberAccess(param, property);
            LambdaExpression orderByExpression = Expression.Lambda(propertyAccessExpression, param);

            string methodName = ascending ? "OrderBy" : "OrderByDescending";

            MethodCallExpression resultExp = Expression.Call(typeof(Queryable), methodName, new Type[] { type, property.PropertyType }, source.Expression, Expression.Quote(orderByExpression));

            return source.Provider.CreateQuery<T>(resultExp);
        }

        public static IEnumerable<T> OrderByLayUI<T>(this IEnumerable<T> list, string sortExpression)
        {
            sortExpression += "";
            string[] parts = sortExpression.Split(' ');
            bool descending = false;
            string property = "";

            if (parts.Length > 0 && parts[0] != "")
            {
                property = parts[0];

                if (parts.Length > 1)
                {
                    descending = parts[1].ToLower().Contains("esc");
                }

                PropertyInfo prop = typeof(T).GetProperty(property);

                if (prop == null)
                {
                    throw new Exception("No property '" + property + "' in + " + typeof(T).Name + "'");
                }

                if (descending)
                    return list.OrderByDescending(x => prop.GetValue(x, null));
                else
                    return list.OrderBy(x => prop.GetValue(x, null));
            }

            return list;
        }


    }
}
