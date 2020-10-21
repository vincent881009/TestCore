using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreTest.Service.Model
{
    public interface IPagedList
    {
    }

    /// <summary>
    /// Paged list
    /// </summary>
    /// <typeparam name="T">T</typeparam>
    public class PagedListLayUI<T> : List<T>, IPagedList
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="pageIndex">Page index</param>
        /// <param name="pageSize">Page size</param>
        public PagedListLayUI(IQueryable<T> source, int pageIndex, int pageSize)
        {
            if (pageIndex < 0)
                pageIndex = 0;
            int total = source.Count();
            this.TotalCount = total;
            this.TotalPages = pageSize > 0 ? total / pageSize : 0;

            if (total % pageSize > 0)
                TotalPages++;

            this.PageSize = pageSize;
            this.PageIndex = pageIndex;
            this.AddRange(source.Skip(pageIndex * pageSize).Take(pageSize).ToList());
        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="pageIndex">Page index</param>
        /// <param name="pageSize">Page size</param>
        public PagedListLayUI(IList<T> source, int pageIndex, int pageSize)
        {
            if (pageIndex < 0)
                pageIndex = 0;
            TotalCount = source.Count();
            TotalPages = pageSize > 0 ? TotalCount / pageSize : 0;

            if (TotalCount % pageSize > 0)
                TotalPages++;

            this.PageSize = pageSize;
            this.PageIndex = pageIndex;
            this.AddRange(source.Skip(pageIndex * pageSize).Take(pageSize).ToList());
        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="pageIndex">Page index</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="totalCount">Total count</param>
        public PagedListLayUI(IEnumerable<T> source, int pageIndex, int pageSize, int totalCount)
        {
            if (pageIndex < 0)
                pageIndex = 0;
            TotalCount = totalCount;
            TotalPages = pageSize > 0 ? TotalCount / pageSize : 0;

            if (TotalCount % pageSize > 0)
                TotalPages++;

            this.PageSize = pageSize;
            this.PageIndex = pageIndex;
            this.AddRange(source);
        }

        public int PageIndex { get; private set; }
        public int PageSize { get; private set; }
        public int TotalCount { get; private set; }
        public int TotalPages { get; private set; }

        public bool HasPreviousPage
        {
            get { return (PageIndex > 0); }
        }
        public bool HasNextPage
        {
            get { return (PageIndex + 1 < TotalPages); }
        }
    }
}
