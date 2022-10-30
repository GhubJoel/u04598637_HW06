using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u04598637_HW06.Helper
{
    public class PageData<T> where T:class
    {
        public IEnumerable<T> Data { get; set; }
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
    }
}