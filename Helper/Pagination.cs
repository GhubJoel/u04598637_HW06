using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u04598637_HW06.Helper
{
    public static class Pagination
    {
        public static PageData<T> PagedResult<T>(this List<T> list, int PageNumber, int PageSize) where T : class
        {
            var result = new PageData<T>();
            result.Data = list.Skip(PageSize * (PageNumber - 1)).Take(PageSize).ToList();
            result.TotalPages = Convert.ToInt32(Math.Ceiling((double)list.Count() / PageSize));
            result.CurrentPage = PageNumber;
            return result;
        }
    }
}