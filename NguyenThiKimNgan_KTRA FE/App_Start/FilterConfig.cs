﻿using System.Web;
using System.Web.Mvc;

namespace NguyenThiKimNgan_KTRA_FE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
